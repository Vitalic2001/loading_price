using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace loading_price
{
    public partial class table_textures : Form
    {
        DataSet bazes_textures = new DataSet(); // Таблица для записи текстур из базы

        public table_textures()
        {
            InitializeComponent();
            open_db_textures();
        }

        public void open_db_textures(int var = 1) // Функция для получения данных с БД для проверки текстур.
        {                 // var = 1 - Фильтрации нет,
            try
            {
                string connectionString_price = "Data Source= " +
                    Properties.Settings.Default.path_settings.Replace("\\\\", "\\") + "; " +
                        "Version=3;New=True;Compress=True;"; // Коннект к БД

                
                SQLiteDataAdapter info_max_id_db = new SQLiteDataAdapter("SELECT number, name, text " +
                    "FROM LibraryMaterials " +
                    "WHERE text IS NOT NULL",
                    connectionString_price); // Получаем значение пути к текстурам.

                info_max_id_db.Fill(bazes_textures); // Добавление данных в кэш таблицу

                dataGridView1.DataSource = bazes_textures.Tables[0];


                DataGridViewCheckBoxColumn newColumn = new DataGridViewCheckBoxColumn(); //Создание новой колонки
                {
                    newColumn.Name = "valid_textures";
                    newColumn.HeaderText = "Наличие текстуры";
                    newColumn.Visible = true;
                    newColumn.SortMode = DataGridViewColumnSortMode.Programmatic;

                }


                dataGridView1.Columns.Add(newColumn);
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending); //Сортировка


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                /*  MessageBox.Show($"Ошибка: {ex.Message}\n" +
                      $"Код ошибки: 001");
                  save_log($"____________________________________________\nОшибка: {ex.Message}\n" +
                      $"Код ошибки: 001\n____________________________________________");*/
            }

            
        }

        public void check_text(bool but = false) // Проверка на наличие текстур
        {
            string info_id = "";
            string path_textures = Properties.Settings.Default.path_textures;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (File.Exists(path_textures + row.Cells[3].Value))
                {
                    Console.WriteLine(row.Cells[0].Value);
                    row.Cells[0].Value = true;
                    
                }
                else
                {
                    if (but)
                    {
                        info_id = info_id + "в id с номером: " + row.Cells[1].Value + " нет текстуры " + "\n";
                    }
                    
                    Console.WriteLine(path_textures + row.Cells[3].Value);
                }
            }

            info_text.Text = info_id;
        }

        private void button1_Click(object sender, EventArgs e) // Проверка на наличие текстуры
        {
            check_text(true); //Проверка наличия текстур
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
           check_text(false); //Проверка наличия текстур
        }

        private void table_textures_Resize(object sender, EventArgs e)
        {
            dataGridView1.Height = this.Height - 60;
            info_text.Height = this.Height - 144;
        }
    }
}
