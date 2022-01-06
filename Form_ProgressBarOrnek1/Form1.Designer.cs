
namespace Form_ProgressBarOrnek1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.pb1K = new System.Windows.Forms.PictureBox();
            this.pb1Y = new System.Windows.Forms.PictureBox();
            this.pb3K = new System.Windows.Forms.PictureBox();
            this.pb3Y = new System.Windows.Forms.PictureBox();
            this.pb2K = new System.Windows.Forms.PictureBox();
            this.pb2Y = new System.Windows.Forms.PictureBox();
            this.pb4K = new System.Windows.Forms.PictureBox();
            this.pb4Y = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1K)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3K)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2K)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4K)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4Y)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Un ve Yumurta Karıştırılıyor..";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(538, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çırpma İşlemi Yapılıyor..";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 100);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(538, 23);
            this.progressBar2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Malzemeler Ekleniyor Ve Karıştırılıyor..";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(12, 172);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(538, 23);
            this.progressBar3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(18, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pasta Pişiriliyor..";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(12, 241);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(538, 23);
            this.progressBar4.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // pb1K
            // 
            this.pb1K.Image = ((System.Drawing.Image)(resources.GetObject("pb1K.Image")));
            this.pb1K.Location = new System.Drawing.Point(411, 9);
            this.pb1K.Name = "pb1K";
            this.pb1K.Size = new System.Drawing.Size(31, 24);
            this.pb1K.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1K.TabIndex = 2;
            this.pb1K.TabStop = false;
            // 
            // pb1Y
            // 
            this.pb1Y.Image = ((System.Drawing.Image)(resources.GetObject("pb1Y.Image")));
            this.pb1Y.Location = new System.Drawing.Point(448, 9);
            this.pb1Y.Name = "pb1Y";
            this.pb1Y.Size = new System.Drawing.Size(31, 24);
            this.pb1Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1Y.TabIndex = 2;
            this.pb1Y.TabStop = false;
            // 
            // pb3K
            // 
            this.pb3K.Image = ((System.Drawing.Image)(resources.GetObject("pb3K.Image")));
            this.pb3K.Location = new System.Drawing.Point(411, 142);
            this.pb3K.Name = "pb3K";
            this.pb3K.Size = new System.Drawing.Size(31, 24);
            this.pb3K.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3K.TabIndex = 2;
            this.pb3K.TabStop = false;
            // 
            // pb3Y
            // 
            this.pb3Y.Image = ((System.Drawing.Image)(resources.GetObject("pb3Y.Image")));
            this.pb3Y.Location = new System.Drawing.Point(448, 142);
            this.pb3Y.Name = "pb3Y";
            this.pb3Y.Size = new System.Drawing.Size(31, 24);
            this.pb3Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3Y.TabIndex = 2;
            this.pb3Y.TabStop = false;
            // 
            // pb2K
            // 
            this.pb2K.Image = ((System.Drawing.Image)(resources.GetObject("pb2K.Image")));
            this.pb2K.Location = new System.Drawing.Point(411, 73);
            this.pb2K.Name = "pb2K";
            this.pb2K.Size = new System.Drawing.Size(31, 24);
            this.pb2K.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2K.TabIndex = 2;
            this.pb2K.TabStop = false;
            // 
            // pb2Y
            // 
            this.pb2Y.Image = ((System.Drawing.Image)(resources.GetObject("pb2Y.Image")));
            this.pb2Y.Location = new System.Drawing.Point(448, 73);
            this.pb2Y.Name = "pb2Y";
            this.pb2Y.Size = new System.Drawing.Size(31, 24);
            this.pb2Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2Y.TabIndex = 2;
            this.pb2Y.TabStop = false;
            // 
            // pb4K
            // 
            this.pb4K.Image = ((System.Drawing.Image)(resources.GetObject("pb4K.Image")));
            this.pb4K.Location = new System.Drawing.Point(411, 214);
            this.pb4K.Name = "pb4K";
            this.pb4K.Size = new System.Drawing.Size(31, 24);
            this.pb4K.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4K.TabIndex = 2;
            this.pb4K.TabStop = false;
            // 
            // pb4Y
            // 
            this.pb4Y.Image = ((System.Drawing.Image)(resources.GetObject("pb4Y.Image")));
            this.pb4Y.Location = new System.Drawing.Point(448, 214);
            this.pb4Y.Name = "pb4Y";
            this.pb4Y.Size = new System.Drawing.Size(31, 24);
            this.pb4Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4Y.TabIndex = 2;
            this.pb4Y.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(562, 289);
            this.Controls.Add(this.pb2Y);
            this.Controls.Add(this.pb2K);
            this.Controls.Add(this.pb4Y);
            this.Controls.Add(this.pb4K);
            this.Controls.Add(this.pb3Y);
            this.Controls.Add(this.pb3K);
            this.Controls.Add(this.pb1Y);
            this.Controls.Add(this.pb1K);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pb1K)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3K)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2K)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4K)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox pb1K;
        private System.Windows.Forms.PictureBox pb1Y;
        private System.Windows.Forms.PictureBox pb3K;
        private System.Windows.Forms.PictureBox pb3Y;
        private System.Windows.Forms.PictureBox pb2K;
        private System.Windows.Forms.PictureBox pb2Y;
        private System.Windows.Forms.PictureBox pb4K;
        private System.Windows.Forms.PictureBox pb4Y;
    }
}

