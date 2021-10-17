
namespace Menu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BenchmarkBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.PictureBox();
            this.TempUs = new System.Windows.Forms.Label();
            this.CpuLbl = new System.Windows.Forms.Label();
            this.LimpiarBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimpiarBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // BenchmarkBtn
            // 
            this.BenchmarkBtn.Location = new System.Drawing.Point(637, 130);
            this.BenchmarkBtn.Name = "BenchmarkBtn";
            this.BenchmarkBtn.Size = new System.Drawing.Size(205, 23);
            this.BenchmarkBtn.TabIndex = 0;
            this.BenchmarkBtn.Text = "Benchmark";
            this.BenchmarkBtn.UseVisualStyleBackColor = true;
            this.BenchmarkBtn.Click += new System.EventHandler(this.BenchmarkBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Submenu_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(637, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SalirBtn
            // 
            this.SalirBtn.BackColor = System.Drawing.Color.Transparent;
            this.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalirBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalirBtn.Image")));
            this.SalirBtn.Location = new System.Drawing.Point(741, 2);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(100, 50);
            this.SalirBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalirBtn.TabIndex = 6;
            this.SalirBtn.TabStop = false;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // TempUs
            // 
            this.TempUs.AutoSize = true;
            this.TempUs.BackColor = System.Drawing.Color.Transparent;
            this.TempUs.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TempUs.Location = new System.Drawing.Point(29, 114);
            this.TempUs.Name = "TempUs";
            this.TempUs.Size = new System.Drawing.Size(0, 75);
            this.TempUs.TabIndex = 7;
            // 
            // CpuLbl
            // 
            this.CpuLbl.AutoSize = true;
            this.CpuLbl.BackColor = System.Drawing.Color.Transparent;
            this.CpuLbl.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CpuLbl.Location = new System.Drawing.Point(29, 297);
            this.CpuLbl.Name = "CpuLbl";
            this.CpuLbl.Size = new System.Drawing.Size(0, 75);
            this.CpuLbl.TabIndex = 8;
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.BackColor = System.Drawing.Color.Transparent;
            this.LimpiarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimpiarBtn.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarBtn.Image")));
            this.LimpiarBtn.Location = new System.Drawing.Point(278, 158);
            this.LimpiarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(247, 116);
            this.LimpiarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LimpiarBtn.TabIndex = 9;
            this.LimpiarBtn.TabStop = false;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 426);
            this.Controls.Add(this.LimpiarBtn);
            this.Controls.Add(this.CpuLbl);
            this.Controls.Add(this.TempUs);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BenchmarkBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimpiarBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BenchmarkBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox SalirBtn;
        private System.Windows.Forms.Label TempUs;
        private System.Windows.Forms.Label CpuLbl;
        private System.Windows.Forms.PictureBox LimpiarBtn;
    }
}

