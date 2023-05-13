namespace WinFormsApp3
{
    partial class rezervasyon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox5 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            lblAirportStatus2 = new Label();
            cbAirport2 = new ComboBox();
            cbCity2 = new ComboBox();
            cbCountry2 = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            button2 = new Button();
            yasli = new CheckBox();
            engelli = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            soyad = new TextBox();
            ad = new TextBox();
            button1 = new Button();
            lblAirportStatus = new Label();
            cbAirport = new ComboBox();
            cbCity = new ComboBox();
            cbCountry = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(lblAirportStatus2);
            groupBox5.Controls.Add(cbAirport2);
            groupBox5.Controls.Add(cbCity2);
            groupBox5.Controls.Add(cbCountry2);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(button2);
            groupBox5.Controls.Add(yasli);
            groupBox5.Controls.Add(engelli);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(soyad);
            groupBox5.Controls.Add(ad);
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(lblAirportStatus);
            groupBox5.Controls.Add(cbAirport);
            groupBox5.Controls.Add(cbCity);
            groupBox5.Controls.Add(cbCountry);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(dateTimePicker1);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label1);
            groupBox5.Location = new Point(35, 32);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1087, 337);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Rezervasyon";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(20, 83);
            label16.Name = "label16";
            label16.Size = new Size(53, 17);
            label16.TabIndex = 35;
            label16.Text = "Nereye:";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(18, 43);
            label15.Name = "label15";
            label15.Size = new Size(62, 17);
            label15.TabIndex = 34;
            label15.Text = "Nereden:";
            // 
            // lblAirportStatus2
            // 
            lblAirportStatus2.AutoSize = true;
            lblAirportStatus2.Location = new Point(741, 85);
            lblAirportStatus2.Name = "lblAirportStatus2";
            lblAirportStatus2.Size = new Size(0, 15);
            lblAirportStatus2.TabIndex = 33;
            // 
            // cbAirport2
            // 
            cbAirport2.FormattingEnabled = true;
            cbAirport2.Location = new Point(574, 77);
            cbAirport2.Name = "cbAirport2";
            cbAirport2.Size = new Size(121, 23);
            cbAirport2.TabIndex = 32;
            cbAirport2.SelectedIndexChanged += cbAirport2_SelectedIndexChanged;
            // 
            // cbCity2
            // 
            cbCity2.FormattingEnabled = true;
            cbCity2.Location = new Point(347, 77);
            cbCity2.Name = "cbCity2";
            cbCity2.Size = new Size(121, 23);
            cbCity2.TabIndex = 31;
            cbCity2.SelectedIndexChanged += cbCity2_SelectedIndexChanged;
            // 
            // cbCountry2
            // 
            cbCountry2.FormattingEnabled = true;
            cbCountry2.Location = new Point(152, 77);
            cbCountry2.Name = "cbCountry2";
            cbCountry2.Size = new Size(121, 23);
            cbCountry2.TabIndex = 30;
            cbCountry2.SelectedIndexChanged += cbCountry2_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(504, 85);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 29;
            label12.Text = "Hava Alanı";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(299, 85);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 28;
            label13.Text = "Şehir";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(110, 85);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 27;
            label14.Text = "Ülke";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Erkek", "Kız", "Diğer" });
            comboBox1.Location = new Point(86, 258);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 266);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 25;
            label5.Text = "Cinsiyet";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(371, 222);
            label11.Name = "label11";
            label11.Size = new Size(10, 15);
            label11.TabIndex = 24;
            label11.Text = " ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(257, 186);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 23;
            label10.Text = "Seçilen Koltuk:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(257, 222);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 22;
            label9.Text = "Kalan Koltuk Sayısı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(357, 186);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 21;
            label8.Text = "Seçilmedi";
            label8.Click += label8_Click;
            // 
            // button2
            // 
            button2.Location = new Point(257, 128);
            button2.Name = "button2";
            button2.Size = new Size(86, 35);
            button2.TabIndex = 20;
            button2.Text = "Koltuk Seçin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // yasli
            // 
            yasli.AutoSize = true;
            yasli.Location = new Point(163, 304);
            yasli.Name = "yasli";
            yasli.Size = new Size(49, 19);
            yasli.TabIndex = 19;
            yasli.Text = "Yaşlı";
            yasli.UseVisualStyleBackColor = true;
            // 
            // engelli
            // 
            engelli.AutoSize = true;
            engelli.Location = new Point(62, 304);
            engelli.Name = "engelli";
            engelli.Size = new Size(61, 19);
            engelli.TabIndex = 18;
            engelli.Text = "Engelli";
            engelli.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 225);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 17;
            label7.Text = "Soyad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 191);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 16;
            label6.Text = "Ad:";
            // 
            // soyad
            // 
            soyad.Location = new Point(86, 217);
            soyad.Name = "soyad";
            soyad.Size = new Size(126, 23);
            soyad.TabIndex = 15;
            // 
            // ad
            // 
            ad.Location = new Point(86, 183);
            ad.Name = "ad";
            ad.Size = new Size(126, 23);
            ad.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(415, 259);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 13;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblAirportStatus
            // 
            lblAirportStatus.AutoSize = true;
            lblAirportStatus.Location = new Point(741, 45);
            lblAirportStatus.Name = "lblAirportStatus";
            lblAirportStatus.Size = new Size(0, 15);
            lblAirportStatus.TabIndex = 12;
            // 
            // cbAirport
            // 
            cbAirport.FormattingEnabled = true;
            cbAirport.Location = new Point(574, 37);
            cbAirport.Name = "cbAirport";
            cbAirport.Size = new Size(121, 23);
            cbAirport.TabIndex = 11;
            cbAirport.SelectedIndexChanged += cmbAirports_SelectedIndexChanged;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(347, 37);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(121, 23);
            cbCity.TabIndex = 10;
            cbCity.SelectedIndexChanged += cmbCities_SelectedIndexChanged;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(152, 37);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(121, 23);
            cbCountry.TabIndex = 9;
            cbCountry.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 138);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Tarih Girin";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(86, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 45);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Hava Alanı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 45);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Şehir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 45);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "Ülke";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(35, 388);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1087, 169);
            listBox1.TabIndex = 20;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // rezervasyon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 566);
            Controls.Add(listBox1);
            Controls.Add(groupBox5);
            Name = "rezervasyon";
            Text = "Form1";
            Load += Form1_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbAirport;
        private ComboBox cbCity;
        private ComboBox cbCountry;
        private Label lblAirportStatus;
        private Label label7;
        private Label label6;
        private TextBox soyad;
        private TextBox ad;
        private Button button1;
        private CheckBox yasli;
        private CheckBox engelli;
        private ListBox listBox1;
        private Button button2;
        public Label label8;
        public Label label11;
        private Label label10;
        private Label label9;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox cbAirport2;
        private ComboBox cbCity2;
        private ComboBox cbCountry2;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblAirportStatus2;
        private Label label16;
        private Label label15;
    }
}