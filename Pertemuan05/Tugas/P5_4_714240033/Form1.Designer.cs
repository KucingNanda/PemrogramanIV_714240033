namespace P5_4_714240033
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSepakBola = new System.Windows.Forms.CheckBox();
            this.cbBasket = new System.Windows.Forms.CheckBox();
            this.cbBuluTangkis = new System.Windows.Forms.CheckBox();
            this.cbRenang = new System.Windows.Forms.CheckBox();
            this.cbPanahan = new System.Windows.Forms.CheckBox();
            this.cbYoga = new System.Windows.Forms.CheckBox();
            this.cbVoli = new System.Windows.Forms.CheckBox();
            this.cbTenis = new System.Windows.Forms.CheckBox();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PENDAFTARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(366, 77);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(181, 20);
            this.txtNama.TabIndex = 4;
            this.txtNama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbJenisKelamin
            // 
            this.cmbJenisKelamin.FormattingEnabled = true;
            this.cmbJenisKelamin.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cmbJenisKelamin.Location = new System.Drawing.Point(366, 115);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(181, 21);
            this.cmbJenisKelamin.TabIndex = 5;
            this.cmbJenisKelamin.Text = "--Pilih Jenis Kelamin--";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(366, 154);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalLahir.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPanahan);
            this.groupBox1.Controls.Add(this.cbYoga);
            this.groupBox1.Controls.Add(this.cbVoli);
            this.groupBox1.Controls.Add(this.cbTenis);
            this.groupBox1.Controls.Add(this.cbBuluTangkis);
            this.groupBox1.Controls.Add(this.cbRenang);
            this.groupBox1.Controls.Add(this.cbBasket);
            this.groupBox1.Controls.Add(this.cbSepakBola);
            this.groupBox1.Location = new System.Drawing.Point(134, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 175);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbJadwal4);
            this.groupBox2.Controls.Add(this.rbJadwal3);
            this.groupBox2.Controls.Add(this.rbJadwal2);
            this.groupBox2.Controls.Add(this.rbJadwal1);
            this.groupBox2.Location = new System.Drawing.Point(417, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 175);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // cbSepakBola
            // 
            this.cbSepakBola.AutoSize = true;
            this.cbSepakBola.Location = new System.Drawing.Point(26, 25);
            this.cbSepakBola.Name = "cbSepakBola";
            this.cbSepakBola.Size = new System.Drawing.Size(81, 17);
            this.cbSepakBola.TabIndex = 0;
            this.cbSepakBola.Text = "Sepak Bola";
            this.cbSepakBola.UseVisualStyleBackColor = true;
            // 
            // cbBasket
            // 
            this.cbBasket.AutoSize = true;
            this.cbBasket.Location = new System.Drawing.Point(145, 23);
            this.cbBasket.Name = "cbBasket";
            this.cbBasket.Size = new System.Drawing.Size(59, 17);
            this.cbBasket.TabIndex = 1;
            this.cbBasket.Text = "Basket";
            this.cbBasket.UseVisualStyleBackColor = true;
            // 
            // cbBuluTangkis
            // 
            this.cbBuluTangkis.AutoSize = true;
            this.cbBuluTangkis.Location = new System.Drawing.Point(145, 60);
            this.cbBuluTangkis.Name = "cbBuluTangkis";
            this.cbBuluTangkis.Size = new System.Drawing.Size(88, 17);
            this.cbBuluTangkis.TabIndex = 3;
            this.cbBuluTangkis.Text = "Bulu Tangkis";
            this.cbBuluTangkis.UseVisualStyleBackColor = true;
            // 
            // cbRenang
            // 
            this.cbRenang.AutoSize = true;
            this.cbRenang.Location = new System.Drawing.Point(26, 61);
            this.cbRenang.Name = "cbRenang";
            this.cbRenang.Size = new System.Drawing.Size(64, 17);
            this.cbRenang.TabIndex = 2;
            this.cbRenang.Text = "Renang";
            this.cbRenang.UseVisualStyleBackColor = true;
            // 
            // cbPanahan
            // 
            this.cbPanahan.AutoSize = true;
            this.cbPanahan.Location = new System.Drawing.Point(145, 134);
            this.cbPanahan.Name = "cbPanahan";
            this.cbPanahan.Size = new System.Drawing.Size(69, 17);
            this.cbPanahan.TabIndex = 7;
            this.cbPanahan.Text = "Panahan";
            this.cbPanahan.UseVisualStyleBackColor = true;
            // 
            // cbYoga
            // 
            this.cbYoga.AutoSize = true;
            this.cbYoga.Location = new System.Drawing.Point(26, 133);
            this.cbYoga.Name = "cbYoga";
            this.cbYoga.Size = new System.Drawing.Size(51, 17);
            this.cbYoga.TabIndex = 6;
            this.cbYoga.Text = "Yoga";
            this.cbYoga.UseVisualStyleBackColor = true;
            // 
            // cbVoli
            // 
            this.cbVoli.AutoSize = true;
            this.cbVoli.Location = new System.Drawing.Point(145, 97);
            this.cbVoli.Name = "cbVoli";
            this.cbVoli.Size = new System.Drawing.Size(43, 17);
            this.cbVoli.TabIndex = 5;
            this.cbVoli.Text = "Voli";
            this.cbVoli.UseVisualStyleBackColor = true;
            // 
            // cbTenis
            // 
            this.cbTenis.AutoSize = true;
            this.cbTenis.Location = new System.Drawing.Point(26, 97);
            this.cbTenis.Name = "cbTenis";
            this.cbTenis.Size = new System.Drawing.Size(52, 17);
            this.cbTenis.TabIndex = 4;
            this.cbTenis.Text = "Tenis";
            this.cbTenis.UseVisualStyleBackColor = true;
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Location = new System.Drawing.Point(26, 24);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(169, 17);
            this.rbJadwal1.TabIndex = 0;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin s/d Rabu, 14.00 - 16.00";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Location = new System.Drawing.Point(26, 59);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(176, 17);
            this.rbJadwal2.TabIndex = 1;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Selasa s/d Kamis, 14.00 - 16.00";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Location = new System.Drawing.Point(26, 132);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(129, 17);
            this.rbJadwal4.TabIndex = 3;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu, 13.00 - 20.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Location = new System.Drawing.Point(26, 96);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(179, 17);
            this.rbJadwal3.TabIndex = 2;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Sabtu s/d Minggu, 09.00 - 11.00";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(309, 392);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btnTampilkan.TabIndex = 9;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(417, 392);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 10;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.cmbJenisKelamin);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ULBI SPORT SCHOOL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPanahan;
        private System.Windows.Forms.CheckBox cbYoga;
        private System.Windows.Forms.CheckBox cbVoli;
        private System.Windows.Forms.CheckBox cbTenis;
        private System.Windows.Forms.CheckBox cbBuluTangkis;
        private System.Windows.Forms.CheckBox cbRenang;
        private System.Windows.Forms.CheckBox cbBasket;
        private System.Windows.Forms.CheckBox cbSepakBola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
    }
}

