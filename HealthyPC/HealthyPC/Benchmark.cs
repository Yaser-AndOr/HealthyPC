using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Management;
using System.Data.OleDb;

namespace HealthyPC
{
    public partial class Benchmark : Base
    {
        public Benchmark()
        {
            Cargar();
            Cnc.cnn = new OleDbConnection();
            Cnc.cnn.ConnectionString = $@"PROVIDER=SQLOLEDB;{Cnc.server}";
            InitializeComponent();
            BarraPB.Visible = false;
            Tipo.Visible = false;
            CompLbl.Visible = false;
            Comparacion.Visible = false;
            Mono.Visible = false;
            Multi.Visible = false;
        }
        public void Cargar()
        {
       
            TempLbl.BackColor = Cambio.fondo[Global.MdCO];
            UsoLbl.BackColor = Cambio.fondo[Global.MdCO];
            this.BackgroundImage = Image.FromFile(Cambio.Logo1[Global.MdCO]);
            AccionBtn.Image = Image.FromFile(Cambio.Logo2[Global.MdCO]);
            CerrarBtn.Image = Image.FromFile(Cambio.LogoS[Global.MdCO]);
        }
        private void Cambio1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
        static ManagementObjectSearcher proce = new ManagementObjectSearcher("select * from Win32_Processor");
        private void Pruebas()
        {
            String nombre = "";
            foreach (ManagementObject obj in proce.Get())
                nombre = $"{obj["Name"]}";
            Tipo.Text = "Ejecutando mononucleo";
            Tipo.Visible = true;
            BarraPB.Visible = true;
            for (int x = 0; x < 10; x++)
                BarraPB.Value++;
            Thread.Sleep(1000);
            Double Puntajemn = Math.Round(BenchMonoN(), 2);
            Tipo.Text = "Ejecutando multinucleo";
            for (int x = 10; x < 55; x++)
                BarraPB.Value++;
            Thread.Sleep(1000);
            Double Puntajemt = Math.Round(BenchMultiN(), 2);
            for (int x = 55; x < 100; x++)
                BarraPB.Value++;
            MessageBox.Show($"Puntaje de Benchmark CPU: {Puntajemn}, {Puntajemt}");
            Cnc.conn.Open();
            Cnc.insert = new SqlCommand($"Insert into Pruebas_Crudo values({Global.ID},'{nombre}',{Puntajemn},{Puntajemt});", Cnc.conn);
            Cnc.insert.ExecuteNonQuery();
            Cnc.conn.Close();
            Double mono = 0, multi = 0;
            Cnc.conn.Open();
            Cnc.select = new SqlCommand($"select AVG(Mononucleo) AS Mono from Pruebas_Crudo where Procesador_Act = '{nombre}'", Cnc.conn);
            Cnc.dr = Cnc.select.ExecuteReader();
            if (Cnc.dr.Read())
                mono = Math.Round((Double.Parse(Cnc.dr["Mono"].ToString().Trim())), 2);
            Cnc.conn.Close();
            Cnc.conn.Open();
            Cnc.select = new SqlCommand($"select Avg(Multinucleo) AS Multi from Pruebas_Crudo where Procesador_Act = '{nombre}'", Cnc.conn);
            Cnc.dr = Cnc.select.ExecuteReader();
            if (Cnc.dr.Read())
                multi = Math.Round((Double.Parse(Cnc.dr["Multi"].ToString().Trim())), 2);
            Cnc.conn.Close();
            try
            {
                Cnc.conn.Open();
                Cnc.insert = new SqlCommand($"Insert into Pruebas_Prom values('{nombre}',{mono},{multi});", Cnc.conn);
                Cnc.insert.ExecuteNonQuery();
                Cnc.conn.Close();
            }
            catch (Exception)
            {
                Cnc.conn.Close();
                Cnc.conn.Open();
                Cnc.insert = new SqlCommand($"UPDATE Pruebas_Prom SET Mononucleo = '{mono}', Multinucleo = '{multi}' WHERE Proc_Act = '{nombre}';", Cnc.conn);
                Cnc.insert.ExecuteNonQuery();
                Cnc.conn.Close();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"Combobox", Cnc.conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            Comparacion.DataSource = dt;
            Comparacion.DisplayMember = "Proc_Act";
            Mono.DataSource = dt;
            Mono.DisplayMember = "Mononucleo";
            Multi.DataSource = dt;
            Multi.DisplayMember = "Multinucleo";
            Cnc.conn.Close();
            CompLbl.Visible = true;
            Comparacion.Visible = true;
            Mono.Visible = true;
            Multi.Visible = true;
            BarraPB.Value = 0;
            BarraPB.Visible = false;
            Tipo.Visible = false;
        }
        private void AccionBtn_Click(object sender, EventArgs e)
        {
            Pruebas();
        }
        private Double BenchMultiN()
        {
            Double puntaje = 0;
            Stopwatch periodo = new Stopwatch();
            periodo.Start();
            Parallel.For(0, 1000000000, delegate (int i) { });
            periodo.Stop();
            Double tiempodebench = periodo.Elapsed.TotalMilliseconds;
            puntaje = ((Math.Pow((tiempodebench), -1)) * 256000) * 3.7015;
            return puntaje;
        }
        private Double BenchMonoN()
        {
            Double puntaje = 0;
            Stopwatch periodo = new Stopwatch();
            periodo.Start();
            for(int x = 0; x < 1000000; x++) { }
            periodo.Stop();
            Double tiempodebench = periodo.Elapsed.TotalMilliseconds;
            puntaje = ((Math.Pow((tiempodebench), -1)) * 25.6) * 3.7015;
            return puntaje;
        }
        private void Mono_SelectedIndexChanged(object sender, EventArgs e)
        {
            object x = Mono.SelectedItem;
            Comparacion.SelectedItem = x;
            Multi.SelectedItem = x;
        }
        private void Multi_SelectedIndexChanged(object sender, EventArgs e)
        {
            object x = Multi.SelectedItem;
            Comparacion.SelectedItem = x;
            Mono.SelectedItem = x;
        }
        private void Comparacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            object x = Comparacion.SelectedItem;
            Mono.SelectedItem = x;
            Multi.SelectedItem = x;
        }
    }
}