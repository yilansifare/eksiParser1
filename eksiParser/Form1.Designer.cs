namespace eksiParser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_cek = new System.Windows.Forms.Button();
            this.textBox_adres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_excel = new System.Windows.Forms.Button();
            this.button_xml = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sqlitebaglantiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlitebaglantiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlitebaglantiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlitebaglantiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_listele
            // 
            this.button_listele.BackColor = System.Drawing.Color.LimeGreen;
            this.button_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_listele.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_listele.Location = new System.Drawing.Point(563, 211);
            this.button_listele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(127, 34);
            this.button_listele.TabIndex = 0;
            this.button_listele.Text = "Entryleri Listele";
            this.button_listele.UseVisualStyleBackColor = false;
            this.button_listele.Click += new System.EventHandler(this.button_listele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 253);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(974, 317);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_cek
            // 
            this.button_cek.BackColor = System.Drawing.Color.DarkRed;
            this.button_cek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cek.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cek.ForeColor = System.Drawing.SystemColors.Control;
            this.button_cek.Location = new System.Drawing.Point(150, 67);
            this.button_cek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cek.Name = "button_cek";
            this.button_cek.Size = new System.Drawing.Size(104, 41);
            this.button_cek.TabIndex = 2;
            this.button_cek.Text = "Entryleri Çek";
            this.button_cek.UseVisualStyleBackColor = false;
            this.button_cek.Click += new System.EventHandler(this.button_cek_Click);
            // 
            // textBox_adres
            // 
            this.textBox_adres.Location = new System.Drawing.Point(12, 41);
            this.textBox_adres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_adres.Name = "textBox_adres";
            this.textBox_adres.Size = new System.Drawing.Size(400, 20);
            this.textBox_adres.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 11);
            this.label1.TabIndex = 5;
            this.label1.Text = "Başlık Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(135, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "https://eksisozluk.com/ataturk--89989 şeklinde";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 174);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(688, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 11);
            this.label3.TabIndex = 8;
            this.label3.Text = "İstediğiniz tabloyu listeden seçip \"Entryleri Listele\" Butonuna basınız:";
            // 
            // button_excel
            // 
            this.button_excel.BackColor = System.Drawing.Color.Green;
            this.button_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_excel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_excel.Location = new System.Drawing.Point(675, 578);
            this.button_excel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(138, 39);
            this.button_excel.TabIndex = 9;
            this.button_excel.Text = "Tabloyu Excel\'e Aktar";
            this.button_excel.UseVisualStyleBackColor = false;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // button_xml
            // 
            this.button_xml.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_xml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xml.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_xml.Location = new System.Drawing.Point(829, 578);
            this.button_xml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_xml.Name = "button_xml";
            this.button_xml.Size = new System.Drawing.Size(138, 39);
            this.button_xml.TabIndex = 10;
            this.button_xml.Text = "Tabloyu xml Olarak Aktar";
            this.button_xml.UseVisualStyleBackColor = false;
            this.button_xml.Click += new System.EventHandler(this.button_xml_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(423, 41);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(263, 22);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yapan Eden:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(661, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eksiParser.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(82, 577);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 50);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eksiParser.Properties.Resources.lemonade_155482_640;
            this.pictureBox1.Location = new System.Drawing.Point(696, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sqlitebaglantiBindingSource
            // 
            this.sqlitebaglantiBindingSource.DataSource = typeof(eksiParser.sqlite_baglanti);
            // 
            // sqlitebaglantiBindingSource1
            // 
            this.sqlitebaglantiBindingSource1.DataSource = typeof(eksiParser.sqlite_baglanti);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(979, 630);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_xml);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_adres);
            this.Controls.Add(this.button_cek);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_listele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(999, 673);
            this.MinimumSize = new System.Drawing.Size(999, 673);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ek$i Başlık Yedekleyici";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlitebaglantiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlitebaglantiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sqlitebaglantiBindingSource;
        private System.Windows.Forms.BindingSource sqlitebaglantiBindingSource1;
        private System.Windows.Forms.Button button_cek;
        private System.Windows.Forms.TextBox textBox_adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.Button button_xml;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

