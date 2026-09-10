using System.Text;

namespace LibreriasEstructurasAlquimia
{

    // ESTRUCTURA ESTADO ALQUIMIA

    public enum TDatoYang { Life, Tierra, Death, Planet1, Planet2 };

    public enum TDatoYin { Air, Water, Earth, Fire, FirePlanet1, FirePlanet2, Zodiaco };

    public record TElementoYang
    {
        public string sNombre { get; set; }
        public float fValor { get; set; }
        public TDatoYang eTipo { get; set; }

        // Puede ser negativo o positivo
        public int indice { get; set; }

    }

    public record TElementoYin
    {
        public string sNombre { get; set; }
        public float fValor { get; set; }
        public TDatoYin eTipo { get; set; }

        // Puede ser negativo o positivo
        public int indice { get; set; }
    }


    public class CListaAlquimiaYang
    {

        private LinkedList<TElementoYang> listaAlquimia;
        private int indiceMenor = 0;
        private int indiceMayor = 0;

        // Constructor
        public CListaAlquimiaYang()
        {

            listaAlquimia = new LinkedList<TElementoYang>();

            // Generamos los datos por defecto
            InsertarAlFinal("Wick", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Sand", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Sodium", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Stone", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Borax", 0.0f, TDatoYang.Tierra);

            InsertarAlFinal("", 0.0f, TDatoYang.Planet1);

            InsertarAlFinal("Asbes", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Soap", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Soot", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Steel", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Suggar", 0.0f, TDatoYang.Tierra);

            InsertarAlFinal("", 0.0f, TDatoYang.Planet2);

            InsertarAlFinal("Magnet", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Manure", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Quicksilver", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Cerussa", 0.0f, TDatoYang.Tierra);
            InsertarAlFinal("Campbire", 0.0f, TDatoYang.Tierra);

        }

        // Obtención indices actuales
        public void ObtenerIndices(out int menor, out int mayor)
        {
            menor = indiceMenor;
            mayor = indiceMayor;
        }

        // Insertar valores fijos
        // Devuelve el indice
        private int InsertarAlFinal(string nombre, float valor, TDatoYang eTipo)
        {
            TElementoYang elem = new TElementoYang();
            elem.sNombre = nombre;
            elem.fValor = valor;
            elem.eTipo = eTipo;

            // Guardamos con indice mayor y sumamos 1 al indice
            elem.indice = indiceMayor;
            indiceMayor++;

            listaAlquimia.AddLast(elem);
            return elem.indice;

        }

        // Insertar Vida. Principio
        public int InsertarVida(string nombre, float valor)
        {
            TElementoYang elem = new TElementoYang();
            elem.sNombre = nombre;
            elem.fValor = valor;
            elem.eTipo = TDatoYang.Life;

            // Guardamos con indice mayor y sumamos 1 al indice
            elem.indice = indiceMenor-1;
            indiceMenor--;

            listaAlquimia.AddFirst(elem);
            return elem.indice;

        }

        // Insertar Muerte. Final
        public int InsertarMuerte(string nombre, float valor)
        {
            TElementoYang elem = new TElementoYang();
            elem.sNombre = nombre;
            elem.fValor = valor;
            elem.eTipo = TDatoYang.Death;
            listaAlquimia.AddLast(elem);

            // Guardamos con indice mayor y sumamos 1 al indice
            elem.indice = indiceMayor;
            indiceMayor++;

            return elem.indice;

        }

        // nroplaneta : 1 o 2.
        public int? InsertarPlaneta(int nroplaneta, string nombre, float valor)
        {
            foreach (TElementoYang elem in listaAlquimia)
            {
                if (elem.eTipo == TDatoYang.Planet1 && nroplaneta == 1)
                {
                    elem.sNombre = nombre;
                    elem.fValor = valor;
                    return elem.indice;
                }
                if (elem.eTipo == TDatoYang.Planet2 && nroplaneta == 2)
                {
                    elem.sNombre = nombre;
                    elem.fValor = valor;
                    return elem.indice;
                }
            }
            return null;
        }

        // Recorre y muestra salida de los datos
        public string RecorrerMostrarLista()
        {
            StringBuilder sb = new StringBuilder();
            foreach (TElementoYang elem in listaAlquimia)
            {
                string linea = elem.indice.ToString() + "\t" + elem.sNombre + "\t" + elem.fValor.ToString() +
                    "\t" + elem.eTipo.ToString();

                sb.AppendLine(linea);
            }
            return sb.ToString();
        }

        // Buscar por un indice
        public TElementoYang BuscarIndice(int indice)
        {
            var resultado = listaAlquimia.FirstOrDefault(p => p.indice == indice);
            return resultado;
        }

        // Buscar por un nombre
        public TElementoYang BuscarNombre(string nombre)
        {
            var resultado = listaAlquimia.FirstOrDefault(p => p.sNombre == nombre);
            return resultado;
        }

        // Filtrar elementos de un tipo
        public List<TElementoYang> FiltroTipo(TDatoYang tipo)
        {
            var resultado = listaAlquimia.Where(p => p.eTipo == tipo).ToList();
            return resultado;
        }

        // Si no hay siguiente devuelve el mismo
        public int ObtenerIndiceSiguiente(int indice)
        {
            if ((indice < indiceMayor) && (indice >= indiceMenor))
            {
                return (indice + 1);
            }
            return indice;
        }

        // Si no hay siguiente devuelve el mismo
        public int ObtenerIndiceAnterior(int indice)
        {
            if ((indice > indiceMenor) && (indice <= indiceMayor))
            {
                return (indice - 1);
            }
            return indice;
        }



    }



    // ESTRUCTURA ESTADO ALQUIMIA CIRCULAR
    public class CListaAlquimiaYin
    {

        private List<TElementoYin> listaAlquimia;
        private int indiceMenor = 0;
        private int indiceMayor = 0;

        // Es elemento ?
        private bool EsElemento (TDatoYin valor)
        {
            return (valor == TDatoYin.Air || valor == TDatoYin.Fire || valor == TDatoYin.Water || valor == TDatoYin.Earth);
        }

        // Constructor
        public CListaAlquimiaYin(TDatoYin elemento1,TDatoYin elemento2,TDatoYin elemento3)
        {
            // Comprobamos elementos
            if (!EsElemento(elemento1) || !EsElemento(elemento2) || !EsElemento(elemento3))
            {
                throw new ArgumentOutOfRangeException("Los datos de entrada no son elementos");
            }    

            listaAlquimia = new List<TElementoYin>();

            // Generamos los datos por defecto
            InsertarAlFinal("", 0.0f, TDatoYin.Zodiaco);
            // Insertamos los valores del primer stack
            InsertarAlFinal("Wick", 0.0f, elemento1);
            InsertarAlFinal("Sand", 0.0f, elemento1);
            InsertarAlFinal("Sodium", 0.0f, elemento1);
            InsertarAlFinal("Stone", 0.0f, elemento1);
            InsertarAlFinal("Borax", 0.0f, elemento1);

            InsertarAlFinal("", 0.0f, TDatoYin.FirePlanet1);

            InsertarAlFinal("Asbes", 0.0f, elemento2);
            InsertarAlFinal("Soap", 0.0f, elemento2);
            InsertarAlFinal("Soot", 0.0f, elemento2);
            InsertarAlFinal("Steel", 0.0f, elemento2);
            InsertarAlFinal("Suggar", 0.0f, elemento2);

            InsertarAlFinal("", 0.0f, TDatoYin.FirePlanet2);

            InsertarAlFinal("Magnet", 0.0f, elemento3);
            InsertarAlFinal("Manure", 0.0f, elemento3);
            InsertarAlFinal("Quicksilver", 0.0f, elemento3);
            InsertarAlFinal("Cerussa", 0.0f, elemento3);
            InsertarAlFinal("Campbire", 0.0f, elemento3);

        }

        // nroplaneta : 1 o 2.
        public int? InsertarPlaneta(int nroplaneta, string nombre, float valor)
        {
            foreach (TElementoYin elem in listaAlquimia)
            {
                if (elem.eTipo == TDatoYin.FirePlanet1 && nroplaneta == 1)
                {
                    elem.sNombre = nombre;
                    elem.fValor = valor;
                    return elem.indice;
                }
                if (elem.eTipo == TDatoYin.FirePlanet2 && nroplaneta == 2)
                {
                    elem.sNombre = nombre;
                    elem.fValor = valor;
                    return elem.indice;
                }
            }
            return null;
        }

        // Insertamos los valore de Zodiaco
        public void InsertarZodiaco(string nombre, float valor)
        {
            var elemento = listaAlquimia.FirstOrDefault(n => n.eTipo == TDatoYin.Zodiaco);
            elemento.sNombre = nombre;
            elemento.fValor = valor;
        }

        // Insertar valores fijos
        // Devuelve el indice
        private int InsertarAlFinal(string nombre, float valor, TDatoYin eTipo)
        {
            TElementoYin elem = new TElementoYin();
            elem.sNombre = nombre;
            elem.fValor = valor;
            elem.eTipo = eTipo;

            // Guardamos con indice mayor y sumamos 1 al indice
            elem.indice = indiceMayor;
            indiceMayor++;

            listaAlquimia.Add(elem);
            return elem.indice;

        }

        // Obtención indices actuales
        public void ObtenerIndices(out int menor, out int mayor)
        {
            if (listaAlquimia != null)
            {
                menor = 0;
                mayor = listaAlquimia.Count - 1;
            }
            else
            {
                menor = -1;
                mayor = -1;
            }

        }

        public int ObtenerIndiceSiguiente(int indice)
        {
            if (indice<0)
            {
                return 0;
            }

            if (indice==listaAlquimia.Count-1)
            {
                return 0;
            }


            return indice + 1;

        }

        // Si no hay siguiente devuelve el mismo
        public int ObtenerIndiceAnterior(int indice)
        {
            if (indice<0)
            {
                return 0;
            }

            if (indice==0)
            {
                return (listaAlquimia.Count - 1);
            }

            return (indice - 1);
            
        }

        // Recorre y muestra salida de los datos
        public string RecorrerMostrarLista()
        {
            StringBuilder sb = new StringBuilder();
            foreach (TElementoYin elem in listaAlquimia)
            {
                string linea = elem.indice.ToString() + "\t" + elem.sNombre + "\t" + elem.fValor.ToString() +
                    "\t" + elem.eTipo.ToString();

                sb.AppendLine(linea);
            }
            sb.AppendLine("...");
            sb.AppendLine("Forma ciclo con el primer elemento");
            return sb.ToString();
        }

        // Buscar por un indice
        public TElementoYin BuscarIndice(int indice)
        {
            var resultado = listaAlquimia[indice];
            return resultado;
        }

        // Buscar por un nombre
        public TElementoYin BuscarNombre(string nombre)
        {
            var resultado = listaAlquimia.FirstOrDefault(p => p.sNombre == nombre);
            return resultado;
        }

        // Filtrar elementos de un tipo
        public List<TElementoYin> FiltroTipo(TDatoYin tipo)
        {
            var resultado = listaAlquimia.Where(p => p.eTipo == tipo).ToList();
            return resultado;
        }
    }

}