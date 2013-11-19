using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDelivida
{
    class TablaCliente:Tabla
    {

        public void crearTabla()
        {
            campos = new ArrayList();
            campos.Add("nombre");
            campos.Add("dni");
            campos.Add("edad");
            campos.Add("estatura");
            campos.Add("peso");

            nombre = "Cliente";

            cargarDatos();
        }

        public ArrayList filtrarClientes(string campo, string valor)
        {
            ArrayList filtrado = new ArrayList();
            ArrayList seleccionados = filtarFilas(campo, valor);
            Cliente temp;

            for (int i = 0; i < seleccionados.Count; i++)
            {
                temp = obtenerCliente(Convert.ToInt32(seleccionados[i]));
                filtrado.Add(temp);
            }

            return filtrado;
        }

        public Cliente obtenerCliente(int numero)
        {
            Cliente c = new Cliente();
            ArrayList f = obtenerFila(numero);

            c.nombre = (string)f[0];
            c.dni = (string)f[1];
            c.edad = Convert.ToInt32(f[2]);
            c.estatura = Convert.ToDouble(f[3]) / 100;
            c.peso = Convert.ToDouble(f[4]);

            return c;
        }

    }
}
