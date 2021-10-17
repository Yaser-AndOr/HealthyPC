using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.IO;

namespace Menu
{
    public partial class Menu : Form
    {
        private static PerformanceCounter pcPerf = new PerformanceCounter("Thermal zone information", "Temperature", @"\_TZ.THRM");
        private static PerformanceCounter uso = new PerformanceCounter("Processor information", "% Processor time", @"_Total");
        public void medidor()
        {
            try
            {
                TempUs.Text = "" + ((int)pcPerf.NextValue() - 273);
            }
            catch (Exception)
            {
                TempUs.Text = "NaN";
            }
            try
            {
                CPUUs.Text = "" + ((int)uso.NextValue()) + "%";
            }
            catch (Exception)
            {
                TempUs.Text = "NaN";
            }
        }
        public Menu()
        {
            InitializeComponent();
            Carga_Menu();
        }
        private void Carga_Menu()
        {
            Timer Temporizador = new Timer();
            Temporizador.Interval = 25;
            Temporizador.Tick += new EventHandler(Actualizador);
            Temporizador.Start();
            button1.Hide();
            button3.Hide();
            button4.Hide();
        }
        private int pr = 0, anim, i = 0, px = 0, py = 0;

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Submenu_Click(object sender, EventArgs e)
        {
            if (anim == 0)
            {
                py = pictureBox1.Location.Y + pictureBox1.Height;
                anim = 1;
                switch (pr)
                {
                    case 0:
                        px = this.Width + 1;
                        button1.Location = new Point(px, py + 2);
                        button3.Location = new Point(px, py + 30);
                        button4.Location = new Point(px, py + 58);
                        button1.Show();
                        button3.Show();
                        button4.Show();
                        i = px;
                        System.Threading.Thread.Sleep(10);
                        animacionaparecer();
                        break;
                    case 1:
                        px = this.Width - 200;
                        button1.Location = new Point(px, py + 2);
                        button3.Location = new Point(px, py + 30);
                        button4.Location = new Point(px, py + 58);
                        i = px;
                        animaciondesaparecer();
                        break;
                    default:
                        break;
                }
            }
        }
        private static int Archborrados = 0, CarpBorradas = 0;
        private static void BorrarTemporales(string ruta, bool borrar)
        {
            List<string> listaArchivos = Directory.GetFiles(ruta).ToList();
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
            List<string> lstChilFolder = Directory.GetDirectories(ruta).ToList();
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
        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            String lugar = $"c:\\Users\\{Environment.UserName}\\AppData\\Local\\temp";
            BorrarTemporales(lugar, false);
            lugar = $"C:\\Windows\\temp";
            BorrarTemporales(lugar, false);
            MessageBox.Show($"Se han borrado {Archborrados} archivos, y {CarpBorradas} carpetas exitosamente.");
            Archborrados = 0; CarpBorradas = 0;
        }
        private void animacionaparecer()
        {
            i -= 10;
            button1.Location = new Point(i, py + 2);
            button3.Location = new Point(i, py + 30);
            button4.Location = new Point(i, py + 58);
            if (i < this.Width - 200)
            {
                anim = 0;
                pr = 1;
            }
        }
        private void animaciondesaparecer()
        {
            i += 10;
            button1.Location = new Point(i, py + 2);
            button3.Location = new Point(i, py + 30);
            button4.Location = new Point(i, py + 58);
            if (i > this.Width + 1)
            {
                button1.Hide();
                button3.Hide();
                button4.Hide();
                anim = 0;
                pr = 0;
            }
        }
        ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
        private int cuantasveces = 0;
        private void Actualizador(object remitente, EventArgs e)
        {
            cuantasveces++;
            if (cuantasveces >= 20)
            {
                cuantasveces = 0;
                medidor();
            }
            if (anim == 1)
            {
                switch (pr)
                {
                    case 0:
                        animacionaparecer();
                        break;
                    case 1:
                        animaciondesaparecer();
                        break;
                    default:
                        break;
                }
            }
        }

    }
}