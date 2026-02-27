using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using Aspose.Cells;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Diagnostics;
using System.IO;


namespace loading_price
{
    public partial class sustem_control : Form
    {
        Stopwatch stopwatch = new Stopwatch();

        public sustem_control()
        {
            InitializeComponent();            
        }

        public void save_log(string text) //Создание лога по дате, или запись нового лога
        {
            string path_logs_file = Properties.Settings.Default.path_logs.Replace("\\\\", "\\");
            DateTime currentDate = DateTime.Now;
            try
            {
                // Проверяем, существует ли файл
                if (!File.Exists(path_logs_file + "\\" + currentDate.ToString("d") + ".txt"))
                {
                    // Файл не существует, создаем его
                    using (StreamWriter sw = File.CreateText(path_logs_file + "\\" + currentDate.ToString("d") + ".txt"))
                    {
                        sw.WriteLine("Файл создан в " + currentDate.ToString());  // Добавляем немного текста
                    }
                }
                // Файл существует или был только что создан, открываем его
                using (StreamWriter sw = new StreamWriter(path_logs_file + "\\" + currentDate.ToString("d") + ".txt", append: true))
                {

                    //string s;

                    sw.WriteLine(text + ". Загрузка была осуществлена в " + currentDate.ToString());
                }
                Console.ReadKey(); // Ждем нажатия клавиши перед закрытием консоли
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        public void block_but(bool Enab = false)
        {
            load_price.Enabled = Enab; //Кнопка блокируется, чтобы не прервать процесс загрузки.
            load_id_material.Enabled = Enab; //Кнопка блокируется, чтобы не прервать процесс загрузки.
            load_id_edizmerenia.Enabled = Enab; //Кнопка блокируется, чтобы не прервать процесс загрузки.
            unload_price.Enabled = Enab;  //Кнопка блокируется, чтобы не прервать процесс загрузки.
        }

        private async void load_price_Click(object sender, EventArgs e) // Загрузка цен в prototypes.db
        {
            block_but(false); // Блокируем кнопки

            loading_progress.Minimum = 0; // Минимаьное значение для процессбара
            loading_progress.Value = 0; // Начальное значение для процессбара

            Worksheet excel_sheet = load_excel();
            int numbers_cells = 2; //Со 2 строки начинается отсчет, т.к как в 1 строке заголовки
            string log_info = "";
            string Articul_value = "gf";
            string connectionString_price = ""; //Путь к db файлу
            try 
            {
                connectionString_price = "Data Source= " +
                    Properties.Settings.Default.path_prototypes.Replace("\\\\", "\\") + "; " +
                        "Version=3;New=True;Compress=True;"; // Коннект к БД

                DataSet max_id_db = new DataSet(); // Таблица для записи максимального ID в прайсе
                SQLiteDataAdapter info_max_id_db = new SQLiteDataAdapter("SELECT MAX(PriceID) FROM Price",
                    connectionString_price);
                info_max_id_db.Fill(max_id_db);
                int max_id = int.Parse(max_id_db.Tables[0].Rows[0][0].ToString());
                loading_progress.Maximum = max_id + 1; // Получаем Максимальный ID в таблице
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n" +
                    $"Код ошибки: 001");
                save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                    $"Код ошибки: 001\n____________________________________________");
            }

            while (excel_sheet.Cells["A"+ numbers_cells.ToString()].Type.ToString() != "IsNull")
            {                
                try
                {                    
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString_price))
                    {
                        connection.Open();

                        if (excel_sheet.Cells["F" + numbers_cells.ToString()].Type.ToString() == "IsNull")
                        {
                            Articul_value = "null";
                        }   
                        else
                        {
                            Articul_value = excel_sheet.Cells["F" + numbers_cells.ToString()].Value.ToString();
                        }
                        string sql = $"UPDATE Price " +
                             $"SET ConstrID = {excel_sheet.Cells["B" + numbers_cells.ToString()].Value}," +
                             $"MatID = {excel_sheet.Cells["C" + numbers_cells.ToString()].Value}, " +
                             $"MName = '{excel_sheet.Cells["D" + numbers_cells.ToString()].Value}', " +
                             $"UnitsID = {excel_sheet.Cells["E" + numbers_cells.ToString()].Value}, " +
                             $"Articul = {Articul_value}, " +
                             $"Price = {excel_sheet.Cells["G" + numbers_cells.ToString()].Value.ToString().Replace(',', '.')} " +
                             $"WHERE PriceID = {numbers_cells-1}";
                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();

                        }
                    }
                    await System.Threading.Tasks.Task.Run(() =>
                    {
                        Invoke((MethodInvoker)delegate {
                            loading_progress.Value = numbers_cells;
                        });
                    }); 
                    numbers_cells++;
                }
                catch (SyntaxErrorException ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}\n" +
                        $"Код ошибки 002");
                    save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                    $"Код ошибки: 002\n____________________________________________");
                    break;
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}\n" +
                        $"Код ошибки 003");
                    save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                    $"Код ошибки: 003\n____________________________________________");
                    break;
                }                
            }

            block_but(true); // Блокируем кнопки
            loading_progress.Value = 0; // Начальное значение для процессбара
            MessageBox.Show("Прайс успешно выгрузился!");
            save_log($"В таблицу Price выгружено до ячейки с номером: {(numbers_cells - 2).ToString()}");
        }

        Worksheet load_excel()
        {
            Workbook excel_file = new Workbook(Properties.Settings.Default.path_file); //Путь к Excel файлу;
            Worksheet excel_sheet = excel_file.Worksheets[0];

            return excel_sheet;
        }

        private async void unload_price_Click(object sender, EventArgs e)
        {
            
        }

        private void but_settings_Click(object sender, EventArgs e)
        {
            panel_settings.Visible = true; // Открывается панель настроек
            label_path_excel.Text = Properties.Settings.Default.path_file.Replace("\\\\", "\\"); // Подгятиваем путь к файлу
            label_path_prototypes.Text = Properties.Settings.Default.path_prototypes.Replace("\\\\", "\\"); // Подгятиваем путь к файлу
            label_path_settings.Text = Properties.Settings.Default.path_settings.Replace("\\\\", "\\"); // Подгятиваем путь к файлу
            label_path_textures.Text = Properties.Settings.Default.path_textures.Replace("\\\\", "\\"); // Подгятиваем путь к файлу
        }   

        private void exite_settings_panel_Click(object sender, EventArgs e)
        {
            panel_settings.Visible = false; // Закрывается панель настроек
            
        }

        private void but_load_path_excel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string new_path_file_excel = openFileDialog1.FileName;
            Properties.Settings.Default.path_file = new_path_file_excel.Replace("\\", "\\\\");
            label_path_excel.Text = Properties.Settings.Default.path_file.Replace("\\\\", "\\"); // Подгятиваем путь к файлу
            Properties.Settings.Default.Save();
        }

        private void but_load_path_prototypes_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string new_path_prototypes = openFileDialog1.FileName;
            Properties.Settings.Default.path_prototypes = new_path_prototypes.Replace("\\", "\\\\");
            label_path_prototypes.Text = Properties.Settings.Default.path_prototypes.Replace("\\\\", "\\"); // Подгятиваем путь к файлу
            Properties.Settings.Default.Save();
        }

        private void but_load_path_settings_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string new_path_settings = openFileDialog1.FileName;
            Properties.Settings.Default.path_settings = new_path_settings.Replace("\\", "\\\\");
            label_path_settings.Text = Properties.Settings.Default.path_settings.Replace("\\\\", "\\"); // Подгятиваем путь к файлу
            Properties.Settings.Default.Save();

        }

        private void but_open_logs_Click(object sender, EventArgs e) //Открытие папки с логами
        {

            //C:\Users\podma\OneDrive\Документы\logs_loading_price
            string path_doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //Получение пути
            if (Directory.Exists(path_doc + "\\logs_loading_price")) // Проверка наличия папки
            {
                Process.Start("explorer.exe", path_doc + "\\logs_loading_price");
            }
            else
            {
                MessageBox.Show("Не можем найти указанную папку по пути: " +
                    path_doc + "\\logs_loading_price");
            }
        }

        private async void load_id_material_Click(object sender, EventArgs e) // Загрузка id материалов
        {
            block_but(false); // Блокируем кнопки

            loading_progress.Minimum = 21; // Минимаьное значение для процессбара
            loading_progress.Value = 21; // Начальное значение для процессбара

            Worksheet excel_sheet = load_excel();
            int numbers_cells = 2; //Со 2 строки начинается отсчет, т.к как в 1 строке заголовки
            string log_info = "";
            string Articul_value = "gf";
            string connectionString_price = ""; //Путь к db файлу
            try
            {
                connectionString_price = "Data Source= " +
                    Properties.Settings.Default.path_prototypes.Replace("\\\\", "\\") + "; " +
                        "Version=3;New=True;Compress=True;"; // Коннект к БД

                DataSet max_id_db = new DataSet(); // Таблица для записи максимального ID в прайсе
                SQLiteDataAdapter info_max_id_db = new SQLiteDataAdapter("SELECT MAX(MaterialID) FROM Materials",
                    connectionString_price);
                info_max_id_db.Fill(max_id_db);
                int max_id = int.Parse(max_id_db.Tables[0].Rows[0][0].ToString());
                loading_progress.Maximum = max_id + 1; // Получаем Максимальный ID в таблице
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n" +
                    $"Код ошибки: 001");
                save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                    $"Код ошибки: 001\n____________________________________________");
            }

            while (excel_sheet.Cells["R" + numbers_cells.ToString()].Type.ToString() != "IsNull")
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString_price))
                    {
                        connection.Open();

                        string sql = $"UPDATE Materials " +
                             $"SET Name = '{excel_sheet.Cells["S" + numbers_cells.ToString()].Value}' " +
                             $"WHERE MaterialID = {numbers_cells + 19}"; //Материал Id начинается с 21.

                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();

                        }
                    }

                    await System.Threading.Tasks.Task.Run(() =>
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            loading_progress.Value = numbers_cells+20;
                            Console.WriteLine(numbers_cells);
                        });
                    });
                    numbers_cells++;

                }
                catch (SyntaxErrorException ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}\n" +
                        $"Код ошибки 002");
                    save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                    $"Код ошибки: 002\n____________________________________________");
                    break;
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}\n" +
                        $"Код ошибки 003");
                    save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                    $"Код ошибки: 003\n____________________________________________");
                    break;
                }
            }

            block_but(true); // Блокируем кнопки

            MessageBox.Show("Материалы успешно выгрузились!");
            loading_progress.Value = 21; // Начальное значение для процессбара

            save_log($"В таблицу Price выгружено до ячейки с номером: {(numbers_cells + 18).ToString()}");

        }

        private async void load_id_edizmerenia_Click(object sender, EventArgs e) // Згрузка единиц измерения
        {
            block_but(false); // Блокируем кнопки

            loading_progress.Minimum = 0; // Минимаьное значение для процессбара
            loading_progress.Value = 0; // Начальное значение для процессбара

            Worksheet excel_sheet = load_excel();
            int numbers_cells = 2; //Со 2 строки начинается отсчет, т.к как в 1 строке заголовки
            string log_info = "";
            string Articul_value = "gf";
            string connectionString_price = ""; //Путь к db файлу
            try
            {
                connectionString_price = "Data Source= " +
                    Properties.Settings.Default.path_prototypes.Replace("\\\\", "\\") + "; " +
                        "Version=3;New=True;Compress=True;"; // Коннект к БД

                DataSet max_id_db = new DataSet(); // Таблица для записи максимального ID в прайсе
                SQLiteDataAdapter info_max_id_db = new SQLiteDataAdapter("SELECT MAX(UnitsID) FROM Units",
                    connectionString_price);
                info_max_id_db.Fill(max_id_db);
                int max_id = int.Parse(max_id_db.Tables[0].Rows[0][0].ToString());
                loading_progress.Maximum = max_id + 1; // Получаем Максимальный ID в таблице
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n" +
                    $"Код ошибки: 001");
                save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                    $"Код ошибки: 001\n____________________________________________");
            }

            while (excel_sheet.Cells["V" + numbers_cells.ToString()].Type.ToString() != "IsNull")
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString_price))
                    {
                        connection.Open();

                        string sql = $"UPDATE Units " +
                             $"SET UnitsName = '{excel_sheet.Cells["W" + numbers_cells.ToString()].Value}', " +
                             $"UnitsOkr = {excel_sheet.Cells["X" + numbers_cells.ToString()].Value}, " +
                             $"UnitsType = '{excel_sheet.Cells["Z" + numbers_cells.ToString()].Value}' " +
                             $"WHERE UnitsID = {numbers_cells - 1}";
                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();

                        }
                    }
                    await System.Threading.Tasks.Task.Run(() =>
                    {
                        Invoke((MethodInvoker)delegate {
                            loading_progress.Value = numbers_cells;
                        });
                    });
                    numbers_cells++;
                }
                catch (SyntaxErrorException ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}\n" +
                        $"Код ошибки 002");
                    save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                    $"Код ошибки: 002\n____________________________________________");
                    break;
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}\n" +
                        $"Код ошибки 003");
                    save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                    $"Код ошибки: 003\n____________________________________________");
                    break;
                }
            }

            block_but(true); // Блокируем кнопки

            MessageBox.Show("Единицы измерений выгрузились!");
            loading_progress.Value = 0; // Начальное значение для процессбара
            save_log($"В таблицу Price выгружено до ячейки с номером: {(numbers_cells - 2).ToString()}");
        }

        private void but_path_load_folder_textures_Click(object sender, EventArgs e) // Ручной пути до текстур
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                    return;

                string new_path_textures = folderBrowserDialog.SelectedPath + "\\";

                Properties.Settings.Default.path_textures = new_path_textures.Replace("\\", "\\\\");
                label_path_textures.Text = Properties.Settings.Default.path_textures.Replace("\\\\", "\\"); // Подгятиваем путь к файлу
                Properties.Settings.Default.Save();
            }
            

        }

        private void but_path_autoload_folder_textures_Click(object sender, EventArgs e) // Автоматический поиск пути к текстурам
        {
            try
            {
                string connectionString_price = "Data Source= " +
                    Properties.Settings.Default.path_settings.Replace("\\\\", "\\") + "; " +
                        "Version=3;New=True;Compress=True;"; // Коннект к БД

                DataSet max_id_db = new DataSet(); // Таблица для записи максимального ID в прайсе
                SQLiteDataAdapter info_max_id_db = new SQLiteDataAdapter("SELECT value FROM Settings " +
                    "WHERE id = 1", 
                    connectionString_price); // Получаем значение пути к текстурам.
                info_max_id_db.Fill(max_id_db);
                string path_texrures = max_id_db.Tables[0].Rows[0][0].ToString();

                Properties.Settings.Default.path_textures = path_texrures.Replace("\\", "\\\\");
                label_path_textures.Text = Properties.Settings.Default.path_textures.Replace("\\\\", "\\"); // Подгятиваем путь к папке
                Properties.Settings.Default.Save();

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n" +
                    $"Код ошибки: 001");
                save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                    $"Код ошибки: 001\n____________________________________________");
            }
        }

        private void but_check_textures_Click(object sender, EventArgs e) // Открытие формы для проверки текстур
        {
            Form textures_f = new table_textures();
            textures_f.Show();
        }
    }
}
