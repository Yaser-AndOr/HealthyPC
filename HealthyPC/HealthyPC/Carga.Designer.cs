
namespace HealthyPC
{
    partial class Carga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carga));
            this.BarraLbl = new System.Windows.Forms.Label();
            this.CargarPB = new System.Windows.Forms.ProgressBar();
            this.Continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarraLbl
            // 
            this.BarraLbl.AutoSize = true;
            this.BarraLbl.BackColor = System.Drawing.Color.Transparent;
            this.BarraLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BarraLbl.Location = new System.Drawing.Point(358, 393);
            this.BarraLbl.Name = "BarraLbl";
            this.BarraLbl.Size = new System.Drawing.Size(73, 18);
            this.BarraLbl.TabIndex = 15;
            this.BarraLbl.Text = "Cargando";
            // 
            // CargarPB
            // 
            this.CargarPB.Location = new System.Drawing.Point(231, 359);
            this.CargarPB.Name = "CargarPB";
            this.CargarPB.Size = new System.Drawing.Size(344, 23);
            this.CargarPB.TabIndex = 14;
            // 
            // Continuar
            // 
            this.Continuar.Location = new System.Drawing.Point(356, 414);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(75, 23);
            this.Continuar.TabIndex = 16;
            this.Continuar.Text = "Continuar";
            this.Continuar.UseVisualStyleBackColor = true;
            this.Continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // Carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Continuar);
            this.Controls.Add(this.BarraLbl);
            this.Controls.Add(this.CargarPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga";
            this.Load += new System.EventHandler(this.Carga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BarraLbl;
        private System.Windows.Forms.ProgressBar CargarPB;
        private System.Windows.Forms.Button Continuar;
    }
}