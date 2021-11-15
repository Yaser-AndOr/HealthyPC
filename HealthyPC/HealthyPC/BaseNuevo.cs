using System;
using System.Windows.Forms;

namespace HealthyPC
{
    public partial class BaseNuevo : Form
    {
        public BaseNuevo()
        {
            InitializeComponent();
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}