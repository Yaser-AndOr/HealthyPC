using System;
using System.Drawing;
using System.Windows.Forms;

namespace HealthyPC
{
    public partial class ActivEleg : Form
    {
        public ActivEleg()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(Cambio.LogoP[Global.MdCO]);
            GB.BackColor = Cambio.fondo[Global.MdCO];
        }
        private void Crear_Click(object sender, EventArgs e)
        {
            Nuevo nuevo = new Nuevo();
            this.Close();
            nuevo.Show();
        }
        private void Usar_Click(object sender, EventArgs e)
        {
            Existente exis = new Existente();
            this.Close();
            exis.Show();
        }
    }
}