using System.Diagnostics;
using System.Text;

namespace LibreriaPuenteMetafisicaADA
{
    public class PuenteMetafisicaADA
    {
        // Llamada al primer programa
        public static string LlamadaACristianismoDinamico1 (String ruta,String fich1,String fich2,out bool bok)
        {
            String rutallamada = ruta + "cristianismodinamicoprimero.exe ";
            // Hacer la llamada
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = rutallamada;
                startInfo.Arguments = fich1 + " " + fich2;
                startInfo.CreateNoWindow = true;       // No crea la ventana de comandos
                startInfo.UseShellExecute = false;     // Necesario para ocultar la ventana en algunos casos
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                startInfo.UseShellExecute = false;

                using (Process exeProcess = Process.Start(startInfo))
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    exeProcess.WaitForExit(); // Espera a que el programa externo finalice
                    // Pasar el fichero devuelto a un buffer.
                    string buffer = File.ReadAllText(ruta + fich2,Encoding.UTF8);
                    bok = true;
                    return buffer;
                }
            }
            catch (Exception ex)
            {
                // Manejar el error si el archivo no existe o faltan permisos
                Console.WriteLine("Error al conectar con programa 1 de ADA.");
                
            }
            bok = false;
            return "";
        }

        // Llamada al primer programa
        public static string LlamadaACristianismoDinamico2(String ruta, String fich1, String fich2, out bool bok)
        {
            String rutallamada = ruta + "cristianismodinamicosegundo.exe ";
            // Hacer la llamada
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = rutallamada;
                startInfo.Arguments = fich1 + " " + fich2;
                startInfo.CreateNoWindow = true;       // No crea la ventana de comandos
                startInfo.UseShellExecute = false;     // Necesario para ocultar la ventana en algunos casos
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                startInfo.UseShellExecute = false;

                using (Process exeProcess = Process.Start(startInfo))
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    exeProcess.WaitForExit(); // Espera a que el programa externo finalice
                    // Pasar el fichero devuelto a un buffer.
                    string buffer = File.ReadAllText(ruta + fich2, Encoding.UTF8);
                    bok = true;
                    return buffer;
                }
            }
            catch (Exception ex)
            {
                // Manejar el error si el archivo no existe o faltan permisos
                Console.WriteLine("Error al conectar con programa 2 de ADA.");

            }
            bok = false;
            return "";
        }

    }
}
