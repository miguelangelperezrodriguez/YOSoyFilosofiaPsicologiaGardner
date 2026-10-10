using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace YOSoyFilosofiaPsicologiaGardner
{
    public partial class frmamor : Form
    {
        public frmamor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Ejecutamos programa en consola de Ada
            // 1. Configurar los datos de inicio del proceso
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "amor.exe", // Cambia por la ruta de tu .exe
                CreateNoWindow = false,               // true si quieres ocultar la ventana negra
                UseShellExecute = false               // Recomendado para controlar el proceso directamente
            };

            try
            {
                // 2. Iniciar el proceso
                using (Process proceso = Process.Start(startInfo))
                {
                    Console.WriteLine("Lanzando el programa... Esperando a que finalice.");

                    // 3. Esperar a que el proceso termine
                    proceso.WaitForExit();

                    // 4. Obtener el código de salida (0 suele significar éxito)
                    int codigoSalida = proceso.ExitCode;
                    Console.WriteLine($"El programa finalizó con el código: {codigoSalida}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error al lanzar el programa: {ex.Message}");
            }

            // Leemos salida y la ponemos en el TextBox
            txtsalida.Text = "";
            string[] lineas = File.ReadAllLines("amor.txt");
            txtsalida.Text = string.Join (Environment.NewLine, lineas);

        }
    }
}
