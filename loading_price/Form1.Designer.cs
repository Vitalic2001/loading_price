namespace loading_price
{
    partial class sustem_control
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sustem_control));
            this.load_price = new System.Windows.Forms.Button();
            this.unload_price = new System.Windows.Forms.Button();
            this.loading_progress = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.but_settings = new System.Windows.Forms.Button();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.label_version = new System.Windows.Forms.Label();
            this.but_path_autoload_folder_textures = new System.Windows.Forms.Button();
            this.label_path_textures = new System.Windows.Forms.Label();
            this.but_path_load_folder_textures = new System.Windows.Forms.Button();
            this.but_open_logs = new System.Windows.Forms.Button();
            this.label_path_settings = new System.Windows.Forms.Label();
            this.but_load_path_settings = new System.Windows.Forms.Button();
            this.label_path_prototypes = new System.Windows.Forms.Label();
            this.but_load_path_prototypes = new System.Windows.Forms.Button();
            this.but_load_path_excel = new System.Windows.Forms.Button();
            this.label_path_excel = new System.Windows.Forms.Label();
            this.exite_settings_panel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.load_id_material = new System.Windows.Forms.Button();
            this.load_id_edizmerenia = new System.Windows.Forms.Button();
            this.but_check_textures = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_price
            // 
            this.load_price.BackColor = System.Drawing.Color.Transparent;
            this.load_price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.load_price.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load_price.ForeColor = System.Drawing.SystemColors.Desktop;
            this.load_price.Location = new System.Drawing.Point(45, 45);
            this.load_price.Name = "load_price";
            this.load_price.Size = new System.Drawing.Size(174, 38);
            this.load_price.TabIndex = 0;
            this.load_price.Text = "Загрузить прайс";
            this.load_price.UseVisualStyleBackColor = false;
            this.load_price.Click += new System.EventHandler(this.load_price_Click);
            // 
            // unload_price
            // 
            this.unload_price.BackColor = System.Drawing.Color.Transparent;
            this.unload_price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unload_price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unload_price.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unload_price.ForeColor = System.Drawing.SystemColors.Desktop;
            this.unload_price.Location = new System.Drawing.Point(230, 45);
            this.unload_price.Name = "unload_price";
            this.unload_price.Size = new System.Drawing.Size(174, 38);
            this.unload_price.TabIndex = 1;
            this.unload_price.Text = "Выгрузить прайс";
            this.unload_price.UseVisualStyleBackColor = false;
            this.unload_price.Click += new System.EventHandler(this.unload_price_Click);
            // 
            // loading_progress
            // 
            this.loading_progress.Location = new System.Drawing.Point(13, 24);
            this.loading_progress.Name = "loading_progress";
            this.loading_progress.Size = new System.Drawing.Size(1039, 76);
            this.loading_progress.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.loading_progress);
            this.panel1.Location = new System.Drawing.Point(45, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 127);
            this.panel1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // but_settings
            // 
            this.but_settings.BackColor = System.Drawing.Color.Transparent;
            this.but_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_settings.BackgroundImage")));
            this.but_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_settings.Location = new System.Drawing.Point(1053, 45);
            this.but_settings.Name = "but_settings";
            this.but_settings.Size = new System.Drawing.Size(60, 60);
            this.but_settings.TabIndex = 5;
            this.but_settings.UseVisualStyleBackColor = false;
            this.but_settings.Click += new System.EventHandler(this.but_settings_Click);
            // 
            // panel_settings
            // 
            this.panel_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_settings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_settings.Controls.Add(this.label_version);
            this.panel_settings.Controls.Add(this.but_path_autoload_folder_textures);
            this.panel_settings.Controls.Add(this.label_path_textures);
            this.panel_settings.Controls.Add(this.but_path_load_folder_textures);
            this.panel_settings.Controls.Add(this.but_open_logs);
            this.panel_settings.Controls.Add(this.label_path_settings);
            this.panel_settings.Controls.Add(this.but_load_path_settings);
            this.panel_settings.Controls.Add(this.label_path_prototypes);
            this.panel_settings.Controls.Add(this.but_load_path_prototypes);
            this.panel_settings.Controls.Add(this.but_load_path_excel);
            this.panel_settings.Controls.Add(this.label_path_excel);
            this.panel_settings.Controls.Add(this.exite_settings_panel);
            this.panel_settings.Controls.Add(this.label1);
            this.panel_settings.Location = new System.Drawing.Point(419, 45);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(628, 376);
            this.panel_settings.TabIndex = 6;
            this.panel_settings.Visible = false;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_version.Location = new System.Drawing.Point(378, 13);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(154, 23);
            this.label_version.TabIndex = 10;
            this.label_version.Text = "Version: 0.1 Alpha";
            // 
            // but_path_autoload_folder_textures
            // 
            this.but_path_autoload_folder_textures.BackColor = System.Drawing.Color.Transparent;
            this.but_path_autoload_folder_textures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_path_autoload_folder_textures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_path_autoload_folder_textures.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_path_autoload_folder_textures.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but_path_autoload_folder_textures.Location = new System.Drawing.Point(19, 260);
            this.but_path_autoload_folder_textures.Name = "but_path_autoload_folder_textures";
            this.but_path_autoload_folder_textures.Size = new System.Drawing.Size(120, 41);
            this.but_path_autoload_folder_textures.TabIndex = 16;
            this.but_path_autoload_folder_textures.Text = "Автоматический выбор пути";
            this.but_path_autoload_folder_textures.UseVisualStyleBackColor = false;
            this.but_path_autoload_folder_textures.Click += new System.EventHandler(this.but_path_autoload_folder_textures_Click);
            // 
            // label_path_textures
            // 
            this.label_path_textures.AutoSize = true;
            this.label_path_textures.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_path_textures.Location = new System.Drawing.Point(145, 250);
            this.label_path_textures.Name = "label_path_textures";
            this.label_path_textures.Size = new System.Drawing.Size(58, 13);
            this.label_path_textures.TabIndex = 14;
            this.label_path_textures.Text = "Настройки";
            // 
            // but_path_load_folder_textures
            // 
            this.but_path_load_folder_textures.BackColor = System.Drawing.Color.Transparent;
            this.but_path_load_folder_textures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_path_load_folder_textures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_path_load_folder_textures.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_path_load_folder_textures.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but_path_load_folder_textures.Location = new System.Drawing.Point(19, 213);
            this.but_path_load_folder_textures.Name = "but_path_load_folder_textures";
            this.but_path_load_folder_textures.Size = new System.Drawing.Size(120, 41);
            this.but_path_load_folder_textures.TabIndex = 13;
            this.but_path_load_folder_textures.Text = "Указать путь до папки с текстурами";
            this.but_path_load_folder_textures.UseVisualStyleBackColor = false;
            this.but_path_load_folder_textures.Click += new System.EventHandler(this.but_path_load_folder_textures_Click);
            // 
            // but_open_logs
            // 
            this.but_open_logs.BackColor = System.Drawing.Color.Transparent;
            this.but_open_logs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_open_logs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_open_logs.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_open_logs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but_open_logs.Location = new System.Drawing.Point(19, 307);
            this.but_open_logs.Name = "but_open_logs";
            this.but_open_logs.Size = new System.Drawing.Size(120, 56);
            this.but_open_logs.TabIndex = 12;
            this.but_open_logs.Text = "Открыть логи";
            this.but_open_logs.UseVisualStyleBackColor = false;
            this.but_open_logs.Click += new System.EventHandler(this.but_open_logs_Click);
            // 
            // label_path_settings
            // 
            this.label_path_settings.AutoSize = true;
            this.label_path_settings.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_path_settings.Location = new System.Drawing.Point(145, 177);
            this.label_path_settings.Name = "label_path_settings";
            this.label_path_settings.Size = new System.Drawing.Size(58, 13);
            this.label_path_settings.TabIndex = 11;
            this.label_path_settings.Text = "Настройки";
            // 
            // but_load_path_settings
            // 
            this.but_load_path_settings.BackColor = System.Drawing.Color.Transparent;
            this.but_load_path_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_load_path_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_load_path_settings.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_load_path_settings.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but_load_path_settings.Location = new System.Drawing.Point(19, 153);
            this.but_load_path_settings.Name = "but_load_path_settings";
            this.but_load_path_settings.Size = new System.Drawing.Size(120, 54);
            this.but_load_path_settings.TabIndex = 10;
            this.but_load_path_settings.Text = "Путь к settings";
            this.but_load_path_settings.UseVisualStyleBackColor = false;
            this.but_load_path_settings.Click += new System.EventHandler(this.but_load_path_settings_Click);
            // 
            // label_path_prototypes
            // 
            this.label_path_prototypes.AutoSize = true;
            this.label_path_prototypes.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_path_prototypes.Location = new System.Drawing.Point(145, 117);
            this.label_path_prototypes.Name = "label_path_prototypes";
            this.label_path_prototypes.Size = new System.Drawing.Size(58, 13);
            this.label_path_prototypes.TabIndex = 9;
            this.label_path_prototypes.Text = "Настройки";
            // 
            // but_load_path_prototypes
            // 
            this.but_load_path_prototypes.BackColor = System.Drawing.Color.Transparent;
            this.but_load_path_prototypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_load_path_prototypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_load_path_prototypes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_load_path_prototypes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but_load_path_prototypes.Location = new System.Drawing.Point(19, 93);
            this.but_load_path_prototypes.Name = "but_load_path_prototypes";
            this.but_load_path_prototypes.Size = new System.Drawing.Size(120, 54);
            this.but_load_path_prototypes.TabIndex = 8;
            this.but_load_path_prototypes.Text = "Путь к prototypes";
            this.but_load_path_prototypes.UseVisualStyleBackColor = false;
            this.but_load_path_prototypes.Click += new System.EventHandler(this.but_load_path_prototypes_Click);
            // 
            // but_load_path_excel
            // 
            this.but_load_path_excel.BackColor = System.Drawing.Color.Transparent;
            this.but_load_path_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_load_path_excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_load_path_excel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_load_path_excel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but_load_path_excel.Location = new System.Drawing.Point(19, 49);
            this.but_load_path_excel.Name = "but_load_path_excel";
            this.but_load_path_excel.Size = new System.Drawing.Size(120, 38);
            this.but_load_path_excel.TabIndex = 7;
            this.but_load_path_excel.Text = "Путь к excel";
            this.but_load_path_excel.UseVisualStyleBackColor = false;
            this.but_load_path_excel.Click += new System.EventHandler(this.but_load_path_excel_Click);
            // 
            // label_path_excel
            // 
            this.label_path_excel.AutoSize = true;
            this.label_path_excel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_path_excel.Location = new System.Drawing.Point(145, 65);
            this.label_path_excel.Name = "label_path_excel";
            this.label_path_excel.Size = new System.Drawing.Size(58, 13);
            this.label_path_excel.TabIndex = 7;
            this.label_path_excel.Text = "Настройки";
            // 
            // exite_settings_panel
            // 
            this.exite_settings_panel.BackColor = System.Drawing.Color.Transparent;
            this.exite_settings_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exite_settings_panel.BackgroundImage")));
            this.exite_settings_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exite_settings_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exite_settings_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exite_settings_panel.Location = new System.Drawing.Point(552, 13);
            this.exite_settings_panel.Name = "exite_settings_panel";
            this.exite_settings_panel.Size = new System.Drawing.Size(60, 60);
            this.exite_settings_panel.TabIndex = 6;
            this.exite_settings_panel.UseVisualStyleBackColor = false;
            this.exite_settings_panel.Click += new System.EventHandler(this.exite_settings_panel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки";
            // 
            // load_id_material
            // 
            this.load_id_material.BackColor = System.Drawing.Color.Transparent;
            this.load_id_material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_id_material.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.load_id_material.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load_id_material.ForeColor = System.Drawing.SystemColors.Desktop;
            this.load_id_material.Location = new System.Drawing.Point(45, 89);
            this.load_id_material.Name = "load_id_material";
            this.load_id_material.Size = new System.Drawing.Size(174, 61);
            this.load_id_material.TabIndex = 7;
            this.load_id_material.Text = "Загрузить id материалов";
            this.load_id_material.UseVisualStyleBackColor = false;
            this.load_id_material.Click += new System.EventHandler(this.load_id_material_Click);
            // 
            // load_id_edizmerenia
            // 
            this.load_id_edizmerenia.BackColor = System.Drawing.Color.Transparent;
            this.load_id_edizmerenia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_id_edizmerenia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.load_id_edizmerenia.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load_id_edizmerenia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.load_id_edizmerenia.Location = new System.Drawing.Point(45, 156);
            this.load_id_edizmerenia.Name = "load_id_edizmerenia";
            this.load_id_edizmerenia.Size = new System.Drawing.Size(174, 61);
            this.load_id_edizmerenia.TabIndex = 8;
            this.load_id_edizmerenia.Text = "Загрузить ед. измерения";
            this.load_id_edizmerenia.UseVisualStyleBackColor = false;
            this.load_id_edizmerenia.Click += new System.EventHandler(this.load_id_edizmerenia_Click);
            // 
            // but_check_textures
            // 
            this.but_check_textures.BackColor = System.Drawing.Color.Transparent;
            this.but_check_textures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_check_textures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_check_textures.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_check_textures.ForeColor = System.Drawing.SystemColors.Desktop;
            this.but_check_textures.Location = new System.Drawing.Point(45, 223);
            this.but_check_textures.Name = "but_check_textures";
            this.but_check_textures.Size = new System.Drawing.Size(174, 61);
            this.but_check_textures.TabIndex = 9;
            this.but_check_textures.Text = "Сравнение текстур";
            this.but_check_textures.UseVisualStyleBackColor = false;
            this.but_check_textures.Click += new System.EventHandler(this.but_check_textures_Click);
            // 
            // sustem_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.but_check_textures);
            this.Controls.Add(this.load_id_edizmerenia);
            this.Controls.Add(this.but_settings);
            this.Controls.Add(this.load_id_material);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.unload_price);
            this.Controls.Add(this.load_price);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sustem_control";
            this.Text = "Система управления прайсам";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_price;
        private System.Windows.Forms.Button unload_price;
        private System.Windows.Forms.ProgressBar loading_progress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button but_settings;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exite_settings_panel;
        private System.Windows.Forms.Button but_load_path_excel;
        private System.Windows.Forms.Label label_path_excel;
        private System.Windows.Forms.Label label_path_prototypes;
        private System.Windows.Forms.Button but_load_path_prototypes;
        private System.Windows.Forms.Label label_path_settings;
        private System.Windows.Forms.Button but_load_path_settings;
        private System.Windows.Forms.Button but_open_logs;
        private System.Windows.Forms.Button load_id_material;
        private System.Windows.Forms.Button load_id_edizmerenia;
        private System.Windows.Forms.Button but_path_autoload_folder_textures;
        private System.Windows.Forms.Label label_path_textures;
        private System.Windows.Forms.Button but_path_load_folder_textures;
        private System.Windows.Forms.Button but_check_textures;
        private System.Windows.Forms.Label label_version;
    }
}

