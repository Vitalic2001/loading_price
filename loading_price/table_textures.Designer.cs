namespace loading_price
{
    partial class table_textures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(table_textures));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_check_textures = new System.Windows.Forms.Button();
            this.info_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(865, 569);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // but_check_textures
            // 
            this.but_check_textures.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_check_textures.Location = new System.Drawing.Point(940, 12);
            this.but_check_textures.Name = "but_check_textures";
            this.but_check_textures.Size = new System.Drawing.Size(142, 63);
            this.but_check_textures.TabIndex = 1;
            this.but_check_textures.Text = "Проверка текстур";
            this.but_check_textures.UseVisualStyleBackColor = true;
            this.but_check_textures.Click += new System.EventHandler(this.button1_Click);
            // 
            // info_text
            // 
            this.info_text.Enabled = false;
            this.info_text.Location = new System.Drawing.Point(901, 93);
            this.info_text.Multiline = true;
            this.info_text.Name = "info_text";
            this.info_text.Size = new System.Drawing.Size(210, 475);
            this.info_text.TabIndex = 2;
            // 
            // table_textures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 580);
            this.Controls.Add(this.info_text);
            this.Controls.Add(this.but_check_textures);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "table_textures";
            this.Text = "Таблица для текстур";
            this.Resize += new System.EventHandler(this.table_textures_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_check_textures;
        private System.Windows.Forms.TextBox info_text;
    }
}