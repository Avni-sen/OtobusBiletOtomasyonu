
namespace OtobusBiletOtomasyonu
{
    partial class KayıtFormu
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
            this.TxtIsım = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskdTelefon = new System.Windows.Forms.MaskedTextBox();
            this.RdbErkek = new System.Windows.Forms.RadioButton();
            this.RdbKadin = new System.Windows.Forms.RadioButton();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.BtnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // TxtIsım
            // 
            this.TxtIsım.Location = new System.Drawing.Point(192, 30);
            this.TxtIsım.Name = "TxtIsım";
            this.TxtIsım.Size = new System.Drawing.Size(112, 22);
            this.TxtIsım.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // TxtSoyisim
            // 
            this.TxtSoyisim.Location = new System.Drawing.Point(192, 67);
            this.TxtSoyisim.Name = "TxtSoyisim";
            this.TxtSoyisim.Size = new System.Drawing.Size(112, 22);
            this.TxtSoyisim.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon";
            // 
            // MskdTelefon
            // 
            this.MskdTelefon.Location = new System.Drawing.Point(192, 109);
            this.MskdTelefon.Name = "MskdTelefon";
            this.MskdTelefon.Size = new System.Drawing.Size(112, 22);
            this.MskdTelefon.TabIndex = 2;
            // 
            // RdbErkek
            // 
            this.RdbErkek.AutoSize = true;
            this.RdbErkek.Checked = true;
            this.RdbErkek.Location = new System.Drawing.Point(94, 161);
            this.RdbErkek.Name = "RdbErkek";
            this.RdbErkek.Size = new System.Drawing.Size(70, 21);
            this.RdbErkek.TabIndex = 3;
            this.RdbErkek.TabStop = true;
            this.RdbErkek.Text = "Erkek";
            this.RdbErkek.UseVisualStyleBackColor = true;
            // 
            // RdbKadin
            // 
            this.RdbKadin.AutoSize = true;
            this.RdbKadin.Location = new System.Drawing.Point(233, 161);
            this.RdbKadin.Name = "RdbKadin";
            this.RdbKadin.Size = new System.Drawing.Size(70, 21);
            this.RdbKadin.TabIndex = 4;
            this.RdbKadin.Text = "Kadın";
            this.RdbKadin.UseVisualStyleBackColor = true;
            // 
            // BtnIptal
            // 
            this.BtnIptal.Location = new System.Drawing.Point(88, 199);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(84, 31);
            this.BtnIptal.TabIndex = 5;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = true;
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // BtnTamam
            // 
            this.BtnTamam.Location = new System.Drawing.Point(219, 199);
            this.BtnTamam.Name = "BtnTamam";
            this.BtnTamam.Size = new System.Drawing.Size(84, 31);
            this.BtnTamam.TabIndex = 6;
            this.BtnTamam.Text = "Tamam";
            this.BtnTamam.UseVisualStyleBackColor = true;
            this.BtnTamam.Click += new System.EventHandler(this.BtnTamam_Click);
            // 
            // KayıtFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 259);
            this.Controls.Add(this.BtnTamam);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.RdbKadin);
            this.Controls.Add(this.RdbErkek);
            this.Controls.Add(this.MskdTelefon);
            this.Controls.Add(this.TxtSoyisim);
            this.Controls.Add(this.TxtIsım);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KayıtFormu";
            this.Text = "KayıtFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Button BtnTamam;
        public System.Windows.Forms.TextBox TxtIsım;
        public System.Windows.Forms.TextBox TxtSoyisim;
        public System.Windows.Forms.MaskedTextBox MskdTelefon;
        public System.Windows.Forms.RadioButton RdbErkek;
        public System.Windows.Forms.RadioButton RdbKadin;
    }
}