using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Menu
{
    public partial class Benchmark : Form
    {
        private static PerformanceCounter pcPerf = new PerformanceCounter("Thermal zone information", "Temperature", @"\_TZ.THRM");
        private static PerformanceCounter uso = new PerformanceCounter("Processor information", "% Processor time", @"_Total");
        public void medidor()
        {
            try
            {
                TempLbl.Text = "" + ((int)pcPerf.NextValue() - 273);
            }
            catch (Exception)
            {
                TempLbl.Text = "NaN";
            }
            try
            {
                CpuLbl.Text = "" + ((int)uso.NextValue()) + "%";
            }
            catch (Exception)
            {
                TempLbl.Text = "NaN";
            }
        }
        public Benchmark()
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
            Menu.Hide();
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
                py = SubemuBtn.Location.Y + SubemuBtn.Height;
                anim = 1;
                switch (pr)
                {
                    case 0:
                        px = this.Width + 1;
                        Menu.Location = new Point(px, py + 2);
                        button3.Location = new Point(px, py + 30);
                        button4.Location = new Point(px, py + 58);
                        Menu.Show();
                        button3.Show();
                        button4.Show();
                        i = px;
                        System.Threading.Thread.Sleep(10);
                        animacionaparecer();
                        break;
                    case 1:
                        px = this.Width - 200;
                        Menu.Location = new Point(px, py + 2);
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

        private Double BenchmarkCpu()
        {
            Double puntaje = 0;
            Stopwatch periodo = new Stopwatch();
            periodo.Start();
            Parallel.For(0, 1000000000, delegate (int i) { });
            periodo.Stop();
            Double tiempodebench = periodo.Elapsed.TotalMilliseconds;
            puntaje = (Math.Pow((tiempodebench), -1)) * 256000;
            return puntaje;
        }

        private int conteo = 0;


        private void EjecutarBtn_Click(object sender, EventArgs e)
        {
            Double Puntaje = Math.Round(BenchmarkCpu(),2);
            ResultadoLbl.Text = $"Puntaje de Benchmark CPU: {Puntaje}";
        }

        private void animacionaparecer()
        {
            i -= 10;
            Menu.Location = new Point(i, py + 2);
            button3.Location = new Point(i, py + 30);
            button4.Location = new Point(i, py + 58);
            if (i < this.Width - 200)
            {
                anim = 0;
                pr = 1;
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void animaciondesaparecer()
        {
            i += 10;
            Menu.Location = new Point(i, py + 2);
            button3.Location = new Point(i, py + 30);
            button4.Location = new Point(i, py + 58);
            if (i > this.Width + 1)
            {
                Menu.Hide();
                button3.Hide();
                button4.Hide();
                anim = 0;
                pr = 0;
            }
        }
        ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
        private int cuantasveces = 0;
        private void actualizacion()
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
        private void Actualizador(object remitente, EventArgs e)
        {
            actualizacion();
        }

    }
}