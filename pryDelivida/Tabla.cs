using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDelivida
{
    /*
     * Clase encargada de gestionar datos tabulares en un archivo de texto
     * en forma de valores separados por un caracter (CSV)
     * 
     * Esta clase guarda los datos en un arhivo .csv a modo de una tabla
     * se puede comparar con una hoja de calculo de Excel.
     * 
     */ 
    class Tabla
    {
        //Ruta de la carpeta donde se guarda el archivo de texto
        private static string contenedor; 
        //Caracter usado para separar los valores de una fila
        private static char separador = '|';

        //Nombre de la tabla y del archivo .csv
        public string nombre = "";

        //Lista de los nombres de campos
        protected ArrayList campos = new ArrayList();
        //Lista de la filas que contienen los valores
        protected ArrayList filas = new ArrayList();
        //Ruta del archivo de los datos
        private string ruta;

        /*
         * Metodo CargarDatos
         * Carga los datos contenidos en el archivo 
         * y los coloca en el ArrayList filas
         */
        public void cargarDatos()
        {
            //Construyo la ruta donde se ubica el archivo
            ruta = Path.Combine(contenedor, nombre + ".csv");

            //Si el archivo existe cargamos los datos
            if (File.Exists(ruta))
            {
                //lee los datps del archivo
                string[] datos = File.ReadAllLines(ruta);

                //declaro el arraylist para el contenido
                filas = new ArrayList(datos.Length);
                
               //voy agregando los datos al ArrayList
                for (int i = 0; i < datos.Length; i++)
                {
                    string fila = datos[i];

                    filas.Add(fila);
                }
            }
        }

        /*
         * Guarda los datos contenidos en el archivo 
         * desde el ArrayList filas
         * 
         */
        public void guardarDatos()
        {
            //creo un arreglo
            string[] datos = new string[filas.Count];

            //coloco las filas en el rreglo
            for (int i = 0; i < filas.Count; i++)
            {
                datos[i] = (string)filas[i];

            }

            //Construyo la ruta del archivo
            string ruta = Path.Combine(contenedor, nombre + ".csv");

            //Guardo los datos en el disco duro 
            File.WriteAllLines(ruta, datos);
        }

        //Obtiene una fila especíca a partir de su numero de orden
        public ArrayList obtenerFila(int numero)
        {
            ArrayList fila = new ArrayList();

            if (numero < filas.Count)
            {
                string f = filas[numero].ToString();
                string[] datos = f.Split(separador);

                for (int i = 0; i < datos.Length; i++)
                {
                    fila.Add(datos[i]);
                }
            }

            return fila;
        }

        //Obtiene el nombre de un campo a partir de su numero de orden
        public string obtenerNombreCampo(int numero)
        {
            return (string)campos[numero];
        }

        //
        public string obtenerValor(int numFila, int numCol)
        {
            string valor;

            valor = (string)obtenerFila(numFila)[numCol];

            return valor;
        }

        public string obtenerValorNombre(int numFila, string nombre)
        {
            int numeroCampo = campos.IndexOf(nombre);
            return obtenerValor(numFila, numeroCampo);
        }

        public void agregarFila(ArrayList valores)
        {
            string fila = "";

            for (int i = 0; i < valores.Count; i++)
            {
                fila += (string)valores[i] + separador;
            }

            fila = fila.Remove(fila.Length - 1);

            filas.Add(fila);

            guardarDatos();
        }

        public void actualizarFila(int numfila, ArrayList valores)
        {
            string fila = "";

            for (int i = 0; i < valores.Count; i++)
            {
                fila += (string)valores[i] + separador;
            }

            fila = fila.Remove(fila.Length - 1);

            filas[numfila] = fila;

            guardarDatos();
        }

        public ArrayList filtarFilas(string campo, string valor)
        {
            ArrayList filtradas = new ArrayList();
            int numCampo = campos.IndexOf(campo.ToLower());
            ArrayList filaTemp;

            for (int i = 0; i < filas.Count; i++)
            {
                filaTemp = obtenerFila(i);
                if (filaTemp[numCampo].ToString().Contains(valor))
                {
                    filtradas.Add(i);
                }
            }

            return filtradas;
        }

        public void setCampos(ArrayList nombresCampo)
        {
            campos = nombresCampo;
        }

        public int getTotalFilas()
        {
            return filas.Count;
        }

        public ArrayList getFilas()
        {
            ArrayList f = new ArrayList();

            for (int i = 0; i < getTotalFilas(); i++)
            {
                f.Add(obtenerFila(i));
            }

            return f;
        }

        public static void setContenedor(string ruta)
        {
            contenedor = ruta;
            if (!Directory.Exists(contenedor))
            {
                Directory.CreateDirectory(contenedor);
            }
        }
    }
}
