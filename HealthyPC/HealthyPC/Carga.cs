using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace HealthyPC
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(Cambio.LogoC[Global.MdCO]);
            for (int x = 0; x < 25; x++)
                CargarPB.Value = x;
            int prueba = 0;
            try
            {
                Global.pcPerf = new PerformanceCounter("Thermal zone information", "Temperature", @"\_TZ.THRM");
                prueba = (int)Global.pcPerf.NextValue();
            }
            catch
            {
                MessageBox.Show("xd");
            }
            for (int x = 25; x < 50; x++)
                CargarPB.Value = x;
            try
            {
                prueba = (int)Global.uso.NextValue();
            }
            catch
            {
            }
            for (int x = 50; x < 101; x++)
                CargarPB.Value = x;
        }

        private void Carga_Load(object sender, EventArgs e)
        {
        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}