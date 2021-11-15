
namespace HealthyPC
{
    partial class BaseNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseNuevo));
            this.GB = new System.Windows.Forms.GroupBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Continuar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB
            // 
            this.GB.Controls.Add(this.Contra);
            this.GB.Controls.Add(this.label2);
            this.GB.Controls.Add(this.Correo);
            this.GB.Controls.Add(this.label1);
            this.GB.Location = new System.Drawing.Point(12, 12);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(204, 102);
            this.GB.TabIndex = 0;
            this.GB.TabStop = false;
            this.GB.Text = "Datos del usuario";
            // 
            // Contra
            // 
            this.Contra.Location = new System.Drawing.Point(9, 74);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(189, 20);
            this.Contra.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña nueva:";
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(9, 32);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(189, 20);
            this.Correo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo nuevo:";
            // 
            // Continuar
            // 
            this.Continuar.Location = new System.Drawing.Point(93, 120);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(123, 23);
            this.Continuar.TabIndex = 1;
            this.Continuar.Text = "Continuar";
            this.Continuar.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(12, 120);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // BaseNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 152);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Continuar);
            this.Controls.Add(this.GB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseNuevo";
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Cancelar;
        protected System.Windows.Forms.TextBox Contra;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox Correo;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button Continuar;
        protected System.Windows.Forms.GroupBox GB;
    }
}