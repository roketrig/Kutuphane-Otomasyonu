namespace Kutuphane_Otomasyonu
{
    partial class UyeSayfasi
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
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.txt_kitapId = new System.Windows.Forms.TextBox();
            this.btn_cikisyap = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiptaisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapYazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapDili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(12, 12);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(199, 9);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_yenile.TabIndex = 1;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // txt_kitapId
            // 
            this.txt_kitapId.Location = new System.Drawing.Point(93, 12);
            this.txt_kitapId.Name = "txt_kitapId";
            this.txt_kitapId.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapId.TabIndex = 2;
            // 
            // btn_cikisyap
            // 
            this.btn_cikisyap.Location = new System.Drawing.Point(12, 286);
            this.btn_cikisyap.Name = "btn_cikisyap";
            this.btn_cikisyap.Size = new System.Drawing.Size(75, 23);
            this.btn_cikisyap.TabIndex = 0;
            this.btn_cikisyap.Text = "Çıkış Yap";
            this.btn_cikisyap.UseVisualStyleBackColor = true;
            this.btn_cikisyap.Click += new System.EventHandler(this.btn_cikisyap_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.Kiptaisim,
            this.KitapYazar,
            this.KitapDili,
            this.YayinEvi,
            this.tur,
            this.adet,
            this.sayfasayisi,
            this.basimyili});
            this.dataGridView3.Location = new System.Drawing.Point(12, 41);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(776, 227);
            this.dataGridView3.TabIndex = 3;
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KitapİD";
            this.kitapid.Name = "kitapid";
            // 
            // Kiptaisim
            // 
            this.Kiptaisim.HeaderText = "Kitap İsim";
            this.Kiptaisim.Name = "Kiptaisim";
            // 
            // KitapYazar
            // 
            this.KitapYazar.HeaderText = "Kitap Yazar";
            this.KitapYazar.Name = "KitapYazar";
            // 
            // KitapDili
            // 
            this.KitapDili.HeaderText = "Kitap Dili";
            this.KitapDili.Name = "KitapDili";
            // 
            // YayinEvi
            // 
            this.YayinEvi.HeaderText = "Yayın Evi";
            this.YayinEvi.Name = "YayinEvi";
            // 
            // tur
            // 
            this.tur.HeaderText = "Tür";
            this.tur.Name = "tur";
            // 
            // adet
            // 
            this.adet.HeaderText = "Adet";
            this.adet.Name = "adet";
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.HeaderText = "Sayfasayısı";
            this.sayfasayisi.Name = "sayfasayisi";
            // 
            // basimyili
            // 
            this.basimyili.HeaderText = "Basım Yılı";
            this.basimyili.Name = "basimyili";
            // 
            // UyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.txt_kitapId);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_cikisyap);
            this.Controls.Add(this.btn_ara);
            this.Name = "UyeSayfasi";
            this.Text = "UyeSayfasi";
            this.Load += new System.EventHandler(this.UyeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.TextBox txt_kitapId;
        private System.Windows.Forms.Button btn_cikisyap;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiptaisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapYazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapDili;
        private System.Windows.Forms.DataGridViewTextBoxColumn YayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimyili;
    }
}