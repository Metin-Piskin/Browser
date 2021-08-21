namespace Web_Tarayıcı
{
    partial class Browser
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Geri = new System.Windows.Forms.Button();
            this.İleri = new System.Windows.Forms.Button();
            this.Yenile = new System.Windows.Forms.Button();
            this.Git = new System.Windows.Forms.Button();
            this.aramayeri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-1, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1088, 645);
            this.webBrowser1.TabIndex = 0;
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(12, 12);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(103, 32);
            this.Geri.TabIndex = 1;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // İleri
            // 
            this.İleri.Location = new System.Drawing.Point(181, 11);
            this.İleri.Name = "İleri";
            this.İleri.Size = new System.Drawing.Size(103, 32);
            this.İleri.TabIndex = 2;
            this.İleri.Text = "İleri";
            this.İleri.UseVisualStyleBackColor = true;
            this.İleri.Click += new System.EventHandler(this.İleri_Click);
            // 
            // Yenile
            // 
            this.Yenile.Location = new System.Drawing.Point(359, 11);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(103, 32);
            this.Yenile.TabIndex = 3;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = true;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // Git
            // 
            this.Git.Location = new System.Drawing.Point(971, 12);
            this.Git.Name = "Git";
            this.Git.Size = new System.Drawing.Size(103, 32);
            this.Git.TabIndex = 4;
            this.Git.Text = "Git";
            this.Git.UseVisualStyleBackColor = true;
            this.Git.Click += new System.EventHandler(this.Git_Click);
            // 
            // aramayeri
            // 
            this.aramayeri.Location = new System.Drawing.Point(468, 12);
            this.aramayeri.Name = "aramayeri";
            this.aramayeri.Size = new System.Drawing.Size(497, 32);
            this.aramayeri.TabIndex = 5;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1086, 692);
            this.Controls.Add(this.aramayeri);
            this.Controls.Add(this.Git);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.İleri);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button İleri;
        private System.Windows.Forms.Button Yenile;
        private System.Windows.Forms.Button Git;
        private System.Windows.Forms.TextBox aramayeri;
    }
}

