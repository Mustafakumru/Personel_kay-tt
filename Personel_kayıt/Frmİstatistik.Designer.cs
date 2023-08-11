namespace Personel_kayıt
{
    partial class Frmİstatistik
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
            this.Lbl_ToplamPersonelSayısı = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPersayı = new System.Windows.Forms.Label();
            this.LblEvliper = new System.Windows.Forms.Label();
            this.LblBekarPer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblSahir = new System.Windows.Forms.Label();
            this.LblMaas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Lblortalama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_ToplamPersonelSayısı
            // 
            this.Lbl_ToplamPersonelSayısı.AutoSize = true;
            this.Lbl_ToplamPersonelSayısı.Location = new System.Drawing.Point(78, 107);
            this.Lbl_ToplamPersonelSayısı.Name = "Lbl_ToplamPersonelSayısı";
            this.Lbl_ToplamPersonelSayısı.Size = new System.Drawing.Size(203, 24);
            this.Lbl_ToplamPersonelSayısı.TabIndex = 0;
            this.Lbl_ToplamPersonelSayısı.Text = "Toplam Personel Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evli Personel Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bekar Personel Sayısı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblPersayı
            // 
            this.LblPersayı.AutoSize = true;
            this.LblPersayı.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPersayı.Location = new System.Drawing.Point(316, 107);
            this.LblPersayı.Name = "LblPersayı";
            this.LblPersayı.Size = new System.Drawing.Size(20, 24);
            this.LblPersayı.TabIndex = 3;
            this.LblPersayı.Text = "0";
            // 
            // LblEvliper
            // 
            this.LblEvliper.AutoSize = true;
            this.LblEvliper.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEvliper.Location = new System.Drawing.Point(316, 161);
            this.LblEvliper.Name = "LblEvliper";
            this.LblEvliper.Size = new System.Drawing.Size(20, 24);
            this.LblEvliper.TabIndex = 4;
            this.LblEvliper.Text = "0";
            // 
            // LblBekarPer
            // 
            this.LblBekarPer.AutoSize = true;
            this.LblBekarPer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBekarPer.Location = new System.Drawing.Point(316, 207);
            this.LblBekarPer.Name = "LblBekarPer";
            this.LblBekarPer.Size = new System.Drawing.Size(20, 24);
            this.LblBekarPer.TabIndex = 5;
            this.LblBekarPer.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şehir Sayısı";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LblSahir
            // 
            this.LblSahir.AutoSize = true;
            this.LblSahir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSahir.Location = new System.Drawing.Point(316, 258);
            this.LblSahir.Name = "LblSahir";
            this.LblSahir.Size = new System.Drawing.Size(20, 24);
            this.LblSahir.TabIndex = 7;
            this.LblSahir.Text = "0";
            // 
            // LblMaas
            // 
            this.LblMaas.AutoSize = true;
            this.LblMaas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMaas.Location = new System.Drawing.Point(316, 296);
            this.LblMaas.Name = "LblMaas";
            this.LblMaas.Size = new System.Drawing.Size(20, 24);
            this.LblMaas.TabIndex = 8;
            this.LblMaas.Text = "0";
            this.LblMaas.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ortalama Maaş";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(159, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Toplam Maaş";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Lblortalama
            // 
            this.Lblortalama.AutoSize = true;
            this.Lblortalama.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblortalama.Location = new System.Drawing.Point(316, 347);
            this.Lblortalama.Name = "Lblortalama";
            this.Lblortalama.Size = new System.Drawing.Size(20, 24);
            this.Lblortalama.TabIndex = 11;
            this.Lblortalama.Text = "0";
            // 
            // Frmİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.Lblortalama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblMaas);
            this.Controls.Add(this.LblSahir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblBekarPer);
            this.Controls.Add(this.LblEvliper);
            this.Controls.Add(this.LblPersayı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_ToplamPersonelSayısı);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frmİstatistik";
            this.Text = "Frmİstatistik";
            this.Load += new System.EventHandler(this.Frmİstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ToplamPersonelSayısı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPersayı;
        private System.Windows.Forms.Label LblEvliper;
        private System.Windows.Forms.Label LblBekarPer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblSahir;
        private System.Windows.Forms.Label LblMaas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Lblortalama;
    }
}