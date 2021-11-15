using System;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace HealthyPC
{
    static class Cambio
    {
        static String archConf = $"{Directory.GetCurrentDirectory()}\\config.dll";
        public static void cambioarch()
        {
            using (StreamWriter sw = File.CreateText(archConf))
            {
                sw.WriteLine($"CM={Global.MdCO},AC={Global.Activ},ID={Global.ID}");
            }
        }
        public static String carpeta = $"{Directory.GetCurrentDirectory()}\\Sources";
        public static String[] Logo1 = { $"{carpeta}\\Logo1W.png", $"{carpeta}\\Logo1B.png" };
        public static String[] Logo2 = { $"{carpeta}\\Logo2W.png", $"{carpeta}\\Logo2B.png" };
        public static String[] LogoC = { $"{carpeta}\\LogoCW.png", $"{carpeta}\\LogoCB.png" };
        public static String[] LogoP = { $"{carpeta}\\LogoPW.png", $"{carpeta}\\LogoPB.png" };
        public static String[] LogoS = { $"{carpeta}\\LogoSW.png", $"{carpeta}\\LogoSB.png" };
        public static Color[] fondo = { Color.FromArgb(218, 227, 243), Color.FromArgb(51, 63, 80) };
    }
    static class Global
    {
        public static PerformanceCounter pcPerf;
        public static PerformanceCounter uso = new PerformanceCounter("Processor information", "% Processor time", @"_Total");
        public static int MdCO;
        public static int Activ;
        public static int ID;
        public static int pl;
        public static int LI;
        public static int VS = 2;
    }
    static class cambio
    {
        public static void c1 ()
        {
            Menu mn = new Menu();
            mn.Show();
        }
    }
    static class Config
    {
        static String archConf = $"{Directory.GetCurrentDirectory()}\\config.dll";
        public static void Configurar()
        {
            Global.pl = 0;
            Crear();
            Leer();
        }
        public static void CargarLib()
        {

        }
        public static void Leer()
        {
            using (StreamReader sr = File.OpenText(archConf))
            {
                String[] ls = sr.ReadToEnd().Trim().Split(',');
                foreach (String texto in ls)
                {
                    if (texto.Contains("CM="))
                    {
                        String BW = texto.Trim('M', 'C', '=');
                        Global.MdCO = int.Parse(BW.Trim());
                    }
                    if (texto.Contains("AC="))
                    {
                        String AC = texto.Trim('A', 'C', '=');
                        Global.Activ = int.Parse(AC.Trim());
                    }
                    if (texto.Contains("ID="))
                    {
                        String AC = texto.Trim('I', 'D', '=');
                        Global.ID = int.Parse(AC.Trim());
                    }
                    if (texto.Contains("LI="))
                    {
                        String AC = texto.Trim('L', 'I', '=');
                        Global.LI = int.Parse(AC.Trim());
                    }
                }
            }
        }
        public static void Crear()
        {
            String rein = $"{Directory.GetCurrentDirectory()}\\PLimpieza\\Reinicio";
            if (File.Exists($"{rein}.bat"))
            {
                File.Delete($"{rein}.bat");
            }
            if (File.Exists($"{rein}.vbs"))
            {
                File.Delete($"{rein}.vbs");
            }
            if (!File.Exists(archConf))
            {
                using (StreamWriter sw = File.CreateText(archConf))
                {
                    sw.WriteLine("CM=0,AC=0,ID=0,LI=0");
                }
            }
        }
    }
}