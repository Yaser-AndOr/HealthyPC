using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Management;

namespace HealthyPC
{
    public partial class Nuevo : BaseNuevo
    {
        public Nuevo()
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
                String Comprob = "";
                Cnc.conn.Open();
                Cnc.select = new SqlCommand($"Select Correo_Electronico from Usuario where Correo_Electronico = '{Correo.Text}'", Cnc.conn);
                Cnc.dr = Cnc.select.ExecuteReader();
                if (Cnc.dr.Read())
                {
                    Comprob = Cnc.dr["Correo_Electronico"].ToString().Trim();
                }
                Cnc.conn.Close();
                if (Comprob == Correo.Text.Trim())
                {
                    MessageBox.Show("Este correo ya está registrado");
                }
                else
                {
                    try
                    {
                        Cnc.conn.Open();
                        String insertarParticipante;
                        insertarParticipante = "Insert into Usuario(Correo_Electronico,Contraseña,Procesador_Act)";
                        insertarParticipante += "Values(@correo,@contra,@cpu);";
                        Cnc.insert = new SqlCommand(insertarParticipante, Cnc.conn);
                        Cnc.insert.Parameters.Add(new SqlParameter("@correo", SqlDbType.VarChar));
                        Cnc.insert.Parameters["@correo"].Value = Correo.Text;
                        Cnc.insert.Parameters.Add(new SqlParameter("@contra", SqlDbType.VarChar));
                        Cnc.insert.Parameters["@contra"].Value = Contra.Text;
                        Cnc.insert.Parameters.Add(new SqlParameter("@cpu", SqlDbType.VarChar));
                        Cnc.insert.Parameters["@cpu"].Value = nombre;
                        Cnc.insert.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado");
                        Cnc.conn.Close();
                        Cnc.conn.Open();
                        Cnc.select = new SqlCommand($"Select ID_Usuario from Usuario where Correo_Electronico = '{Correo.Text}'", Cnc.conn);
                        Cnc.dr = Cnc.select.ExecuteReader();
                        if (Cnc.dr.Read())
                        {
                            Global.ID = int.Parse(Cnc.dr["ID_Usuario"].ToString().Trim());
                            Cambio.cambioarch();
                            this.Close();
                            Menu menu = new Menu();
                            menu.Show();
                        }
                        Cnc.conn.Close();
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo agregar el registro");
                    }
                }

            } else
            {
                MessageBox.Show("No deje vacías las casillas");
            }
        }
    }
}