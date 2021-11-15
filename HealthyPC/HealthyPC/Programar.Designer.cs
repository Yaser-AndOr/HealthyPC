
namespace HealthyPC
{
    partial class Programar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programar));
            this.Frecuencia = new System.Windows.Forms.ComboBox();
            this.Activar = new System.Windows.Forms.CheckBox();
            this.GBox = new System.Windows.Forms.GroupBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frecuencia
            // 
            this.Frecuencia.FormattingEnabled = true;
            this.Frecuencia.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Mensual"});
            this.Frecuencia.Location = new System.Drawing.Point(139, 67);
            this.Frecuencia.Name = "Frecuencia";
            this.Frecuencia.Size = new System.Drawing.Size(121, 21);
            this.Frecuencia.TabIndex = 0;
            this.Frecuencia.Text = "Diario";
            // 
            // Activar
            // 
            this.Activar.AutoSize = true;
            this.Activar.Location = new System.Drawing.Point(6, 0);
            this.Activar.Name = "Activar";
            this.Activar.Size = new System.Drawing.Size(158, 17);
            this.Activar.TabIndex = 1;
            this.Activar.Text = "Activar limpieza programada";
            this.Activar.UseVisualStyleBackColor = true;
            this.Activar.CheckedChanged += new System.EventHandler(this.Activar_CheckedChanged);
            // 
            // GBox
            // 
            this.GBox.Controls.Add(this.Cancelar);
            this.GBox.Controls.Add(this.Guardar);
            this.GBox.Controls.Add(this.label1);
            this.GBox.Controls.Add(this.Frecuencia);
            this.GBox.Controls.Add(this.Activar);
            this.GBox.Location = new System.Drawing.Point(12, 12);
            this.GBox.Name = "GBox";
            this.GBox.Size = new System.Drawing.Size(266, 139);
            this.GBox.TabIndex = 2;
            this.GBox.TabStop = false;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(34, 110);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 4;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(139, 110);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 3;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frecuencia de limpieza";
            // 
            // Programar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 163);
            this.Controls.Add(this.GBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Programar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Programar";
            this.GBox.ResumeLayout(false);
            this.GBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Frecuencia;
        private System.Windows.Forms.CheckBox Activar;
        private System.Windows.Forms.GroupBox GBox;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
    }
}