
namespace HealthyPC
{
    partial class Base
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.TempLbl = new System.Windows.Forms.Label();
            this.UsoLbl = new System.Windows.Forms.Label();
            this.Cambio1 = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Limpieza = new System.Windows.Forms.Button();
            this.Oscuro = new System.Windows.Forms.Button();
            this.Cambio2 = new System.Windows.Forms.Button();
            this.AccionBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccionBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.BackColor = System.Drawing.Color.Black;
            this.CerrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(688, 12);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(100, 50);
            this.CerrarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CerrarBtn.TabIndex = 0;
            this.CerrarBtn.TabStop = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // TempLbl
            // 
            this.TempLbl.AutoSize = true;
            this.TempLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.TempLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempLbl.Location = new System.Drawing.Point(24, 92);
            this.TempLbl.Name = "TempLbl";
            this.TempLbl.Size = new System.Drawing.Size(69, 37);
            this.TempLbl.TabIndex = 1;
            this.TempLbl.Text = "0°C";
            // 
            // UsoLbl
            // 
            this.UsoLbl.AutoSize = true;
            this.UsoLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UsoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsoLbl.Location = new System.Drawing.Point(24, 291);
            this.UsoLbl.Name = "UsoLbl";
            this.UsoLbl.Size = new System.Drawing.Size(63, 37);
            this.UsoLbl.TabIndex = 2;
            this.UsoLbl.Text = "0%";
            // 
            // Cambio1
            // 
            this.Cambio1.Location = new System.Drawing.Point(645, 291);
            this.Cambio1.Name = "Cambio1";
            this.Cambio1.Size = new System.Drawing.Size(75, 23);
            this.Cambio1.TabIndex = 4;
            this.Cambio1.Text = "Cambio1";
            this.Cambio1.UseVisualStyleBackColor = true;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(645, 350);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 6;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Limpieza
            // 
            this.Limpieza.Location = new System.Drawing.Point(645, 408);
            this.Limpieza.Name = "Limpieza";
            this.Limpieza.Size = new System.Drawing.Size(123, 23);
            this.Limpieza.TabIndex = 7;
            this.Limpieza.Text = "Programar Limpieza";
            this.Limpieza.UseVisualStyleBackColor = true;
            this.Limpieza.Click += new System.EventHandler(this.Limpieza_Click);
            // 
            // Oscuro
            // 
            this.Oscuro.Location = new System.Drawing.Point(645, 379);
            this.Oscuro.Name = "Oscuro";
            this.Oscuro.Size = new System.Drawing.Size(99, 23);
            this.Oscuro.TabIndex = 8;
            this.Oscuro.Text = "Modo Oscuro";
            this.Oscuro.UseVisualStyleBackColor = true;
            this.Oscuro.Click += new System.EventHandler(this.Oscuro_Click);
            // 
            // Cambio2
            // 
            this.Cambio2.Location = new System.Drawing.Point(645, 321);
            this.Cambio2.Name = "Cambio2";
            this.Cambio2.Size = new System.Drawing.Size(75, 23);
            this.Cambio2.TabIndex = 5;
            this.Cambio2.Text = "Activar";
            this.Cambio2.UseVisualStyleBackColor = true;
            // 
            // AccionBtn
            // 
            this.AccionBtn.BackColor = System.Drawing.Color.Black;
            this.AccionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccionBtn.Image = ((System.Drawing.Image)(resources.GetObject("AccionBtn.Image")));
            this.AccionBtn.Location = new System.Drawing.Point(330, 147);
            this.AccionBtn.Name = "AccionBtn";
            this.AccionBtn.Size = new System.Drawing.Size(143, 154);
            this.AccionBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccionBtn.TabIndex = 10;
            this.AccionBtn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccionBtn);
            this.Controls.Add(this.Oscuro);
            this.Controls.Add(this.Limpieza);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Cambio2);
            this.Controls.Add(this.Cambio1);
            this.Controls.Add(this.UsoLbl);
            this.Controls.Add(this.TempLbl);
            this.Controls.Add(this.CerrarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccionBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.PictureBox CerrarBtn;
        protected System.Windows.Forms.Label TempLbl;
        protected System.Windows.Forms.Label UsoLbl;
        protected System.Windows.Forms.Button Cambio1;
        protected System.Windows.Forms.Button Actualizar;
        protected System.Windows.Forms.Button Limpieza;
        protected System.Windows.Forms.Button Oscuro;
        protected System.Windows.Forms.Button Cambio2;
        protected System.Windows.Forms.PictureBox AccionBtn;
        protected System.Windows.Forms.Label label1;
    }
}

