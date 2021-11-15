
namespace HealthyPC
{
    partial class Benchmark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Benchmark));
            this.BarraPB = new System.Windows.Forms.ProgressBar();
            this.Tipo = new System.Windows.Forms.Label();
            this.Comparacion = new System.Windows.Forms.ComboBox();
            this.CompLbl = new System.Windows.Forms.Label();
            this.Mono = new System.Windows.Forms.ComboBox();
            this.Multi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccionBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TempLbl
            // 
            this.TempLbl.Size = new System.Drawing.Size(83, 37);
            this.TempLbl.Text = "NaN";
            // 
            // Cambio1
            // 
            this.Cambio1.Location = new System.Drawing.Point(645, 321);
            this.Cambio1.Text = "Menu";
            this.Cambio1.Click += new System.EventHandler(this.Cambio1_Click);
            // 
            // Cambio2
            // 
            this.Cambio2.Enabled = false;
            this.Cambio2.Location = new System.Drawing.Point(645, 292);
            this.Cambio2.Visible = false;
            // 
            // AccionBtn
            // 
            this.AccionBtn.Click += new System.EventHandler(this.AccionBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(375, 227);
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.Text = "Ejecutar";
            // 
            // BarraPB
            // 
            this.BarraPB.Location = new System.Drawing.Point(227, 350);
            this.BarraPB.Name = "BarraPB";
            this.BarraPB.Size = new System.Drawing.Size(346, 23);
            this.BarraPB.TabIndex = 12;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.BackColor = System.Drawing.Color.Transparent;
            this.Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(327, 384);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(46, 18);
            this.Tipo.TabIndex = 13;
            this.Tipo.Text = "label2";
            // 
            // Comparacion
            // 
            this.Comparacion.FormattingEnabled = true;
            this.Comparacion.Location = new System.Drawing.Point(148, 63);
            this.Comparacion.Name = "Comparacion";
            this.Comparacion.Size = new System.Drawing.Size(346, 21);
            this.Comparacion.TabIndex = 14;
            this.Comparacion.SelectedIndexChanged += new System.EventHandler(this.Comparacion_SelectedIndexChanged);
            // 
            // CompLbl
            // 
            this.CompLbl.AutoSize = true;
            this.CompLbl.BackColor = System.Drawing.Color.Transparent;
            this.CompLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompLbl.Location = new System.Drawing.Point(308, 32);
            this.CompLbl.Name = "CompLbl";
            this.CompLbl.Size = new System.Drawing.Size(195, 18);
            this.CompLbl.TabIndex = 15;
            this.CompLbl.Text = "Comparación de resultados:";
            // 
            // Mono
            // 
            this.Mono.FormattingEnabled = true;
            this.Mono.Location = new System.Drawing.Point(500, 63);
            this.Mono.Name = "Mono";
            this.Mono.Size = new System.Drawing.Size(72, 21);
            this.Mono.TabIndex = 16;
            this.Mono.SelectedIndexChanged += new System.EventHandler(this.Mono_SelectedIndexChanged);
            // 
            // Multi
            // 
            this.Multi.FormattingEnabled = true;
            this.Multi.Location = new System.Drawing.Point(578, 63);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(72, 21);
            this.Multi.TabIndex = 17;
            this.Multi.SelectedIndexChanged += new System.EventHandler(this.Multi_SelectedIndexChanged);
            // 
            // Benchmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Mono);
            this.Controls.Add(this.CompLbl);
            this.Controls.Add(this.Comparacion);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.BarraPB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Benchmark";
            this.Text = "Benchmark";
            this.Controls.SetChildIndex(this.BarraPB, 0);
            this.Controls.SetChildIndex(this.Tipo, 0);
            this.Controls.SetChildIndex(this.Comparacion, 0);
            this.Controls.SetChildIndex(this.CompLbl, 0);
            this.Controls.SetChildIndex(this.Mono, 0);
            this.Controls.SetChildIndex(this.Multi, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccionBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BarraPB;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.ComboBox Comparacion;
        private System.Windows.Forms.Label CompLbl;
        private System.Windows.Forms.ComboBox Mono;
        private System.Windows.Forms.ComboBox Multi;
    }
}