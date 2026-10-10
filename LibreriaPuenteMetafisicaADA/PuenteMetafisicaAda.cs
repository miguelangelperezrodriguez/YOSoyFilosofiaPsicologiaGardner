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

        // Llamada al segundo programa
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

        // LLamada al tercer programa
        public static string LlamadaACristianismoDinamico3(String ruta, String fich1, String fich2, out bool bok)
        {
            String rutallamada = ruta + "cristianismodinamicotercero.exe ";
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
                Console.WriteLine("Error al conectar con programa 3 de ADA.");

            }
            bok = false;
            return "";
        }

        // LLamada al cuarto programa
        public static string LlamadaACristianismoDinamico4(String ruta, String fich1, String fich2, out bool bok)
        {
            String rutallamada = ruta + "cristianismodinamicocuarto.exe ";
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
                Console.WriteLine("Error al conectar con programa 4 de ADA.");

            }
            bok = false;
            return "";
        }

        // LLamada al quinto programa
        public static string LlamadaACristianismoDinamico5(String ruta, String fich1, String fich2, out bool bok)
        {
            String rutallamada = ruta + "cristianismodinamicoquinto.exe ";
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
                Console.WriteLine("Error al conectar con programa 5 de ADA.");

            }
            bok = false;
            return "";
        }

        // LLamada al sexto programa
        public static string LlamadaACristianismoDinamico6(String ruta, String fich1, String fich2, out bool bok)
        {
            String rutallamada = ruta + "cristianismodinamicosexto.exe ";
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
                Console.WriteLine("Error al conectar con programa 6 de ADA.");

            }
            bok = false;
            return "";
        }

        public static string LlamadaAMetafisica1(String ruta, String fich1, String fich2, out bool bok)
        {
            String rutallamada = ruta + "metafisica1.exe ";
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
                Console.WriteLine("Error al conectar con programa 7 de ADA.");

            }
            bok = false;
            return "";
        }

        public static string LlamadaAMetafisica2(String ruta, String fich1, String fich2, out bool bok)
        {
            String rutallamada = ruta + "metafisica2.exe ";
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
                Console.WriteLine("Error al conectar con programa 8 de ADA.");

            }
            bok = false;
            return "";
        }

        public static string LlamadaAMetafisica3(String ruta, String fich1, String fich2, out bool bok)
        {
            String rutallamada = ruta + "metafisica3.exe ";
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
                Console.WriteLine("Error al conectar con programa 9 de ADA.");

            }
            bok = false;
            return "";
        }

        public static string LlamadaAPipeline(String ruta, String fich1, out bool bok)
        {
            String rutallamada = ruta + "pipeline_metafisica.exe ";
            // Hacer la llamada
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = rutallamada;
                startInfo.Arguments = fich1;
                startInfo.CreateNoWindow = true;       // No crea la ventana de comandos
                startInfo.UseShellExecute = false;     // Necesario para ocultar la ventana en algunos casos
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                startInfo.UseShellExecute = false;

                using (Process exeProcess = Process.Start(startInfo))
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    exeProcess.WaitForExit(); // Espera a que el programa externo finalice
                    // Pasar el fichero devuelto a un buffer.
                    string buffer = File.ReadAllText(ruta + fich1, Encoding.UTF8);
                    bok = true;
                    return buffer;
                }
            }
            catch (Exception ex)
            {
                // Manejar el error si el archivo no existe o faltan permisos
                Console.WriteLine("Error al conectar con programa 10 de ADA.");

            }
            bok = false;
            return "";
        }

    }
}
