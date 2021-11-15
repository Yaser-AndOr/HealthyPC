using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace HealthyPC
{
    public partial class Menu : Base
    {
        public Menu()
        {
            Cargar();
            InitializeComponent();
            BarraPB.Visible = false;
            BarraLbl.Visible = false;
        }
        public void Cargar()
        {
            if (Global.ID == 0)
            {
                Actualizar.Enabled = false;
                Oscuro.Enabled = false;
                Limpieza.Enabled = false;
                Cambio1.Enabled = false;
                Cambio1.Text = "[Activar]";
                Actualizar.Text = "[Activar]";
                Oscuro.Text = "[Activar]";
                Limpieza.Text = "[Activar]";
            }
            TempLbl.BackColor = Cambio.fondo[Global.MdCO];
            UsoLbl.BackColor = Cambio.fondo[Global.MdCO];
            this.BackgroundImage = Image.FromFile(Cambio.Logo1[Global.MdCO]);
            AccionBtn.Image = Image.FromFile(Cambio.Logo2[Global.MdCO]);
            CerrarBtn.Image = Image.FromFile(Cambio.LogoS[Global.MdCO]);
        }
        private void Cambio1_Click_1(object sender, EventArgs e)
        {
            Benchmark bm = new Benchmark();
            this.Close();
            bm.Show();
        }
        String lugar0 = $"c:\\Users\\{Environment.UserName}\\AppData\\Local\\temp";
        String lugar1 = $"C:\\Windows\\temp";
        String lugar2 = $"C:\\Windows\\Prefetch";
        private void AccionBtn_Click(object sender, EventArgs e)
        {
            BarraPB.Visible = true;
            BarraLbl.Visible = true;
            for (int x = 0; x < 10; x++)
            {
                BarraPB.Value++;
            }
            Thread.Sleep(1000);
            BorrarTemporales(lugar0, false);
            for (int x = 10; x < 50; x++)
            {
                BarraPB.Value++;
            }
            BorrarTemporales(lugar1, false);
            for (int x = 50; x < 75; x++)
            {
                BarraPB.Value++;
            }
            BorrarTemporales(lugar2, false);
            for (int x = 75; x < 100; x++)
            {
                BarraPB.Value++;
            }
            MessageBox.Show($"Se han borrado {Archborrados} archivos, y {CarpBorradas} carpetas exitosamente.");
            Archborrados = 0; CarpBorradas = 0;
            BarraPB.Value = 0;
            BarraPB.Visible = false;
            BarraLbl.Visible = false;
        }
        private static int Archborrados = 0, CarpBorradas = 0;

        private void Cambio2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivEleg ae = new ActivEleg();
            ae.Show();
        }
        private static void BorrarTemporales(string ruta, bool borrar)
        {
            string[] listaArchivos = Directory.GetFiles(ruta);
            foreach (string archivo in listaArchivos)
            {
                try
                {
                    File.Delete(archivo);
                    Archborrados++;
                }
                catch (Exception)
                {
                }
            }
            string[] lstChilFolder = Directory.GetDirectories(ruta);
            foreach (string pathFolder in lstChilFolder)
            {
                try
                {
                    BorrarTemporales(pathFolder, true);
                    CarpBorradas++;
                }
                catch (Exception)
                {

                }
            }
            if (borrar)
            {
                Directory.Delete(ruta);
            }
        }
    }
}