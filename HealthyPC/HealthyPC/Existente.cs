using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Management;

namespace HealthyPC
{
    public partial class Existente : BaseNuevo
    {
        public Existente()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(Cambio.LogoP[Global.MdCO]);
            GB.BackColor = Cambio.fondo[Global.MdCO];
            Cnc.cnn.ConnectionString = $"PROVIDER=SQLOLEDB;{Cnc.server}";
        }
        static ManagementObjectSearcher proce = new ManagementObjectSearcher("select * from Win32_Processor");
        private void Continuar_Click(object sender, EventArgs e)
        {
            String nombre = "";
            foreach (ManagementObject obj in proce.Get())
                nombre = $"{obj["Name"]}";
            if (!((Correo.Text.Trim() == "") || (Contra.Text.Trim() == "")))
            {
                String correo = "", contra = "", ID = "";
                Cnc.conn.Open();
                Cnc.select = new SqlCommand($"Select Correo_Electronico from Usuario where Correo_Electronico = '{Correo.Text}'", Cnc.conn);
                Cnc.dr = Cnc.select.ExecuteReader();
                if (Cnc.dr.Read())
                    correo = Cnc.dr["Correo_Electronico"].ToString().Trim();
                Cnc.conn.Close();
                if (correo == Correo.Text.Trim())
                {
                    Cnc.conn.Open();
                    Cnc.select = new SqlCommand($"Select Contraseña from Usuario where Correo_Electronico = '{Correo.Text}'", Cnc.conn);
                    Cnc.dr = Cnc.select.ExecuteReader();
                    if (Cnc.dr.Read())
                    {
                        contra = Cnc.dr["Contraseña"].ToString().Trim();
                    }
                    Cnc.conn.Close();
                    if (contra == Contra.Text.Trim())
                    {
                        Cnc.conn.Open();
                        Cnc.select = new SqlCommand($"Select ID_Usuario from Usuario where Correo_Electronico = '{Correo.Text}'", Cnc.conn);
                        Cnc.dr = Cnc.select.ExecuteReader();
                        if (Cnc.dr.Read())
                        {
                            ID = Cnc.dr["ID_Usuario"].ToString().Trim();
                            Global.ID = int.Parse(ID);
                            Cambio.cambioarch();
                            Cnc.conn.Close();
                            Cnc.conn.Open();
                            Cnc.insert = new SqlCommand($"UPDATE Usuario SET Procesador_Act = '{nombre}' WHERE ID_Usuario = {Global.ID};", Cnc.conn);
                            Cnc.insert.ExecuteNonQuery();
                            Cnc.conn.Close();
                            this.Close();
                            Menu menu = new Menu();
                            menu.Show();
                            //}
                            Cnc.conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña no válida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Correo no válido");
                    }
                }
                else
                {
                    MessageBox.Show("No deje vacías las casillas");
                }
                Cnc.conn.Close();
            }
        }
    }
}