namespace P5_3_714240033
{
    partial class ServiceHP
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
            this.merkhp = new System.Windows.Forms.Label();
            this.os = new System.Windows.Forms.Label();
            this.konfirmasi = new System.Windows.Forms.Label();
            this.cbYa = new System.Windows.Forms.CheckBox();
            this.rb_android = new System.Windows.Forms.RadioButton();
            this.rb_ios = new System.Windows.Forms.RadioButton();
            this.txtMerkHP = new System.Windows.Forms.TextBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // merkhp
            // 
            this.merkhp.AutoSize = true;
            this.merkhp.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.merkhp.Location = new System.Drawing.Point(61, 68);
            this.merkhp.Name = "merkhp";
            this.merkhp.Size = new System.Drawing.Size(62, 18);
            this.merkhp.TabIndex = 0;
            this.merkhp.Text = "Merk HP";
            // 
            // os
            // 
            this.os.AutoSize = true;
            this.os.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.os.Location = new System.Drawing.Point(61, 108);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(25, 18);
            this.os.TabIndex = 1;
            this.os.Text = "OS";
            // 
            // konfirmasi
            // 
            this.konfirmasi.AutoSize = true;
            this.konfirmasi.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.konfirmasi.Location = new System.Drawing.Point(61, 148);
            this.konfirmasi.Name = "konfirmasi";
            this.konfirmasi.Size = new System.Drawing.Size(122, 18);
            this.konfirmasi.TabIndex = 2;
            this.konfirmasi.Text = "Sudah Diperbaiki?";
            // 
            // cbYa
            // 
            this.cbYa.AutoSize = true;
            this.cbYa.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYa.Location = new System.Drawing.Point(190, 148);
            this.cbYa.Name = "cbYa";
            this.cbYa.Size = new System.Drawing.Size(40, 22);
            this.cbYa.TabIndex = 3;
            this.cbYa.Text = "Ya";
            this.cbYa.UseVisualStyleBackColor = true;
            // 
            // rb_android
            // 
            this.rb_android.AutoSize = true;
            this.rb_android.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_android.Location = new System.Drawing.Point(190, 107);
            this.rb_android.Name = "rb_android";
            this.rb_android.Size = new System.Drawing.Size(71, 22);
            this.rb_android.TabIndex = 4;
            this.rb_android.TabStop = true;
            this.rb_android.Text = "Android";
            this.rb_android.UseVisualStyleBackColor = true;
            // 
            // rb_ios
            // 
            this.rb_ios.AutoSize = true;
            this.rb_ios.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ios.Location = new System.Drawing.Point(276, 108);
            this.rb_ios.Name = "rb_ios";
            this.rb_ios.Size = new System.Drawing.Size(44, 22);
            this.rb_ios.TabIndex = 5;
            this.rb_ios.TabStop = true;
            this.rb_ios.Text = "iOS";
            this.rb_ios.UseVisualStyleBackColor = true;
            // 
            // txtMerkHP
            // 
            this.txtMerkHP.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.txtMerkHP.Location = new System.Drawing.Point(190, 65);
            this.txtMerkHP.Name = "txtMerkHP";
            this.txtMerkHP.Size = new System.Drawing.Size(215, 23);
            this.txtMerkHP.TabIndex = 6;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(104, 205);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(272, 205);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 8;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // ServiceHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(450, 276);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.txtMerkHP);
            this.Controls.Add(this.rb_ios);
            this.Controls.Add(this.rb_android);
            this.Controls.Add(this.cbYa);
            this.Controls.Add(this.konfirmasi);
            this.Controls.Add(this.os);
            this.Controls.Add(this.merkhp);
            this.Name = "ServiceHP";
            this.Text = "Service HP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label merkhp;
        private System.Windows.Forms.Label os;
        private System.Windows.Forms.Label konfirmasi;
        private System.Windows.Forms.CheckBox cbYa;
        private System.Windows.Forms.RadioButton rb_android;
        private System.Windows.Forms.RadioButton rb_ios;
        private System.Windows.Forms.TextBox txtMerkHP;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKeluar;
    }
}

