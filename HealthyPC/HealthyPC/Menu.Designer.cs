
namespace HealthyPC
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BarraPB = new System.Windows.Forms.ProgressBar();
            this.BarraLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccionBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TempLbl
            // 
            this.TempLbl.Size = new System.Drawing.Size(83, 37);
            this.TempLbl.Text = "NaN";
            // 
            // UsoLbl
            // 
            this.UsoLbl.Text = "2%";
            // 
            // Cambio1
            // 
            this.Cambio1.Text = "Benchmark";
            this.Cambio1.Click += new System.EventHandler(this.Cambio1_Click_1);
            // 
            // Cambio2
            // 
            this.Cambio2.Click += new System.EventHandler(this.Cambio2_Click);
            // 
            // AccionBtn
            // 
            this.AccionBtn.Click += new System.EventHandler(this.AccionBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(375, 227);
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.Text = "Limpiar";
            // 
            // BarraPB
            // 
            this.BarraPB.Location = new System.Drawing.Point(229, 350);
            this.BarraPB.Name = "BarraPB";
            this.BarraPB.Size = new System.Drawing.Size(344, 23);
            this.BarraPB.TabIndex = 12;
            // 
            // BarraLbl
            // 
            this.BarraLbl.AutoSize = true;
            this.BarraLbl.BackColor = System.Drawing.Color.Transparent;
            this.BarraLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BarraLbl.Location = new System.Drawing.Point(356, 384);
            this.BarraLbl.Name = "BarraLbl";
            this.BarraLbl.Size = new System.Drawing.Size(89, 18);
            this.BarraLbl.TabIndex = 13;
            this.BarraLbl.Text = "Procesando";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BarraLbl);
            this.Controls.Add(this.BarraPB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Controls.SetChildIndex(this.CerrarBtn, 0);
            this.Controls.SetChildIndex(this.TempLbl, 0);
            this.Controls.SetChildIndex(this.UsoLbl, 0);
            this.Controls.SetChildIndex(this.Cambio1, 0);
            this.Controls.SetChildIndex(this.Cambio2, 0);
            this.Controls.SetChildIndex(this.Actualizar, 0);
            this.Controls.SetChildIndex(this.Limpieza, 0);
            this.Controls.SetChildIndex(this.Oscuro, 0);
            this.Controls.SetChildIndex(this.AccionBtn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.BarraPB, 0);
            this.Controls.SetChildIndex(this.BarraLbl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccionBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BarraPB;
        private System.Windows.Forms.Label BarraLbl;
    }
}