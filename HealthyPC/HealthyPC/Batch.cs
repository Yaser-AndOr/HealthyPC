using CodeForce.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyPC
{
    class tareas
    {
        public static String carptar = $"{Directory.GetCurrentDirectory()}\\PLimpieza";
        public static void crear(String archivo, String texto)
        {
            String Arch = $"{carptar}\\{archivo}";
            using (StreamWriter sw = File.CreateText(Arch))
            {
                sw.Write(texto);
            }
        }
        public static void ejecutar(String Archivo)
        {
            String arch = $"{carptar}\\{Archivo}";
            System.Diagnostics.Process.Start(arch);
        }
        public static void eliminar(String archivo)
        {
            String Arch = $"{carptar}\\{archivo}";
            if (File.Exists(Arch))
            {
                File.Delete(Arch);
            }      
        }
        public static void carpetarea() {
            if (!Directory.Exists(carptar))
            {
                Directory.CreateDirectory(carptar);
            }
        }
    }
    class Batch
    {
        public static String nlimp(int Frec)
        {
            String[] frecuencia = { "Daily", "Weekly /D Mon", "Monthly /D 15" };
            String nuevo = $"SCHTASKS /CREATE /SC {frecuencia[Frec]} /TN \"Limpieza Programada\" /TR \"{tareas.carptar}\\PLimpieza.vbs\" /ST 11:00\n" +
                $"TASKKILL /F /IM cmd.exe /T\n";
            return nuevo;
        }
        public static String reinicio()
        {
            String rein = "Timeout /t 3 /nobreak >nul\n" +
                $"cd {Directory.GetCurrentDirectory()}\n" +
                $"start HealthyPC.exe\n";
            return rein;
        }
        public static String limp() {
            String limpieza = "@echo off\n" +
                $"rd /s /q C:\\Users\\{Environment.UserName}\\AppData\\Local\\temp\n" +
                "rd /s /q C:\\Windows\\Prefetch\n" +
                "rd /s /q C:\\Windows\\temp\n" +
                $"md C:\\Users\\{Environment.UserName}\\AppData\\Local\\temp\n" +
                "md C:\\Windows\\temp\n" +
                "md C:\\Windows\\Prefetch\n" +
                "TASKKILL /F /IM cmd.exe /T\n";
            return limpieza;
        }
        public static String elim()
        {
            String nuevo = $"SCHTASKS /Delete /TN \"Limpieza Programada\" /F\n" +
                $"TASKKILL /F /IM cmd.exe /T\n";
            return nuevo;
        }
    }
    class VBS
    {
        public static String Discreto(String Archivo)
        {
            String nuevo = $"Set WshShell = CreateObject(\"WScript.Shell\")\n" +
                $"WshShell.Run chr(34) & \"{tareas.carptar}\\{Archivo}\" & Chr(34), 0\n" +
                "Set WshShell = Nothing\n";
            return nuevo;
        }
    }
}