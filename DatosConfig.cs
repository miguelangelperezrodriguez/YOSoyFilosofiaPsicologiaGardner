using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOSoyFilosofiaPsicologiaGardner
{
    public static class DatosConfig
    {
        // Ruta del ejecutable
        public static string AppPath { get; set; }

        public static string bufferTexto;

        // Convierte un texto del formulario en valor decimal
        public static string ConvertirFlotanteADA (string texto)
        {
            return texto.Replace(",", ".");
        }

    }

}
