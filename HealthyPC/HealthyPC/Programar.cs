using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace HealthyPC
{
    public partial class Programar : Form
    {
        public Programar()
        {
            InitializeComponent();
            Cargar();
        }
        public void Cargar()
        {
            GBox.BackColor = Cambio.fondo[Global.MdCO];
            this.BackgroundImage = Image.FromFile(Cambio.LogoP[Global.MdCO]);
        }
        private void Activar_CheckedChanged(object sender, EventArgs e)
        {
            if (Activar.Checked == true)
            {
                Frecuencia.Enabled = true;
            }
            if (Activar.Checked == false)
            {
                Frecuencia.Enabled = false;
            }
        }
        private void NTarea()
        {
            tareas.carpetarea();
            String BLimp = Batch.limp();
            String BTareaban = Batch.elim();
            String BNLimp = Batch.nlimp(Frecuencia.SelectedIndex);

            String VLimp = VBS.Discreto("Limpieza.bat");
            String VTareaban = VBS.Discreto("Borrar.bat");
            String VNLimp = VBS.Discreto("Crear.bat");

            tareas.crear("Borrar.bat", BTareaban);
            tareas.crear("Borrar.vbs", VTareaban);
            tareas.crear("Limpieza.bat", BLimp);
            tareas.crear("Limpieza.vbs", VLimp);
            tareas.crear("Crear.bat", BNLimp);
            tareas.crear("Crear.vbs", VNLimp);

            try
            {
                tareas.ejecutar("Borrar.vbs");
                tareas.ejecutar("Crear.vbs");
            } catch (Exception)
            {

            }
            try
            {
            }
            catch (Exception)
            {

            }
        }
        private void FCache()
        {
            tareas.eliminar("Borrar.vbs");
            tareas.eliminar("Crear.vbs");
            tareas.eliminar("Crear.bat");
            tareas.eliminar("Borrar.bat");
        }
        private void FTarea()
        {
            tareas.eliminar("Limpieza.vbs");
            tareas.eliminar("Limpieza.bat");
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            switch (Activar.Checked)
            {
                case true:
                    NTarea();
                    Thread.Sleep(1000);
                    FCache();
                    break;
                case false:
                    FTarea();
                    break;
                default:
                    break;
            }
            this.Close();
            Global.pl = 0;
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Global.pl = 0;
        }
    }
}