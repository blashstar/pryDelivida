using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDelivida
{
    class Tabla
    {
        private static string contenedor;
        private static char separador = '|';

        public string nombre = "";
        protected ArrayList campos = new ArrayList();
        protected ArrayList filas = new ArrayList();

        private string ruta;

        public void cargarDatos()
        {
            ruta = Path.Combine(contenedor, nombre + ".csv");

            if (File.Exists(ruta))
            {
                string[] datos = File.ReadAllLines(ruta);

                filas = new ArrayList(datos.Length);

                for (int i = 0; i < datos.Length; i++)
                {
                    string fila = datos[i];
                    //string[] fila = linea.Split(separador);

                    filas.Add(fila);
                }
            }
        }

        public void guardarDatos()
        {
            string[] datos = new string[filas.Count];

            for (int i = 0; i < filas.Count; i++)
            {
                datos[i] = (string)filas[i];

            }

            string ruta = Path.Combine(contenedor, nombre + ".csv");
            File.WriteAllLines(ruta, datos);
        }

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

        public string obtenerNombreCampo(int numero)
        {
            return (string)campos[numero];
        }

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
