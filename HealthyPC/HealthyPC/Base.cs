using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HealthyPC
{
    public partial class Base : Form
    {
        public Base()
        {
            Timer Temporizador = new Timer();
            Temporizador.Interval = 1;
            Temporizador.Tick += new EventHandler(Actualizador);
            Temporizador.Start();
            InitializeComponent();
        }
        private void CerrarBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void Limpieza_Click(object sender, System.EventArgs e)
        {
            if (Global.pl == 0)
            {
                Programar pg = new Programar();
                pg.Show();
                Global.pl = 1;
            }
        }
        private void Oscuro_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("El programa se reiniciará para aplicar los cambios");
            switch (Global.MdCO)
            {
                case 0:
                    Global.MdCO = 1;
                    break;
                case 1:
                    Global.MdCO = 0;
                    break;
            }
            Cambio.cambioarch();
            String ReinB = Batch.reinicio();
            String ReinV = VBS.Discreto("Reinicio.bat");
            tareas.crear("Reinicio.bat", ReinB);
            tareas.crear("Reinicio.vbs", ReinV);
            tareas.ejecutar("Reinicio.vbs");
            Application.Exit();
        }
        public void medidor()
        {
            try
            {
                TempLbl.Text = "" + ((int)Global.pcPerf.NextValue() - 273);
            }
            catch (Exception)
            {
                TempLbl.Text = "NaN";
            }
            try
            {
                UsoLbl.Text = "" + ((int)Global.uso.NextValue()) + "%";
            }
            catch (Exception)
            {
                UsoLbl.Text = "NaN";
            }
        }
        private int count;
        private void Actualizador(object remitente, EventArgs e)
        {
            count++;
            if (count >= 50)
            {
                medidor();
                count = 0;
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            int version = 0;
            String link = "";
            Cnc.conn.Open();
            Cnc.select = new SqlCommand($"select top 1 Version_Programa from Actualizacion order by Version_Programa desc", Cnc.conn);
            Cnc.dr = Cnc.select.ExecuteReader();
            if (Cnc.dr.Read())
            {
                version = int.Parse(Cnc.dr["Version_Programa"].ToString().Trim());
            }
            Cnc.conn.Close();
            MessageBox.Show($"{version}");
            if (version > Global.VS)
            {
                Cnc.conn.Open();
                Cnc.select = new SqlCommand($"select top 1 Enlace from Actualizacion order by Version_Programa desc", Cnc.conn);
                Cnc.dr = Cnc.select.ExecuteReader();
                if (Cnc.dr.Read())
                {
                    link = Cnc.dr["Enlace"].ToString().Trim();
                    System.Diagnostics.Process.Start(link);
                }
                Cnc.conn.Close();
            }
        }
    }
}