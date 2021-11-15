
namespace HealthyPC
{
    partial class ActivEleg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivEleg));
            this.GB = new System.Windows.Forms.GroupBox();
            this.Usar = new System.Windows.Forms.Button();
            this.Crear = new System.Windows.Forms.Button();
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB
            // 
            this.GB.Controls.Add(this.Usar);
            this.GB.Controls.Add(this.Crear);
            this.GB.Location = new System.Drawing.Point(12, 12);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(146, 79);
            this.GB.TabIndex = 0;
            this.GB.TabStop = false;
            this.GB.Text = "Activación";
            // 
            // Usar
            // 
            this.Usar.Location = new System.Drawing.Point(6, 48);
            this.Usar.Name = "Usar";
            this.Usar.Size = new System.Drawing.Size(134, 23);
            this.Usar.TabIndex = 2;
            this.Usar.Text = "Usar cuenta existente";
            this.Usar.UseVisualStyleBackColor = true;
            this.Usar.Click += new System.EventHandler(this.Usar_Click);
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(6, 19);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(134, 23);
            this.Crear.TabIndex = 1;
            this.Crear.Text = "Crear cuenta";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // ActivEleg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(169, 102);
            this.Controls.Add(this.GB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActivEleg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activar";
            this.GB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Usar;
    }
}