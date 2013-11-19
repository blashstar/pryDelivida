using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDelivida
{

    class TablaPedido:Tabla
    {
        TablaCliente tablaCliente;

        public void crearTabla()
        {
            campos = new ArrayList();
            campos.Add("idcliente");
            campos.Add("fecha");
            campos.Add("producto");
            campos.Add("cantidad");
            campos.Add("precio");

            nombre = "Pedido";

            cargarDatos();

            tablaCliente = new TablaCliente();
            tablaCliente.crearTabla();
        }

        public ArrayList filtrarPedidos(string campo, string valor)
        {
            ArrayList filtrado = new ArrayList();
            ArrayList seleccionados = filtarFilas(campo, valor);
            Pedido temp;

            for (int i = 0; i < seleccionados.Count; i++)
            {
                temp = obtenerPedido(Convert.ToInt32(seleccionados[i]));
                filtrado.Add(temp);
            }

            return filtrado;
        }

        public ArrayList listarPedidosCliente(int id)
        {
            ArrayList filtradas = new ArrayList();
            ArrayList filaTemp;

            for (int i = 0; i < filas.Count; i++)
            {
                filaTemp = obtenerFila(i);
                System.Diagnostics.Debug.Print("{0}: {1}:{2}", i,filaTemp[0], id);
                if (filaTemp[0].ToString() == id.ToString())
                {
                    filtradas.Add(obtenerPedido(i));
                }
            }

            return filtradas;
        }

        public Pedido obtenerPedido(int numero)
        {
            Pedido p = new Pedido();
            ArrayList f = obtenerFila(numero);

            int idCliente = Convert.ToInt32(f[0]);

            p.cliente = tablaCliente.obtenerCliente(idCliente);
            p.fecha = (string)f[1];
            p.producto = (string)f[2];
            p.cantidad = Convert.ToInt32(f[3]);
            p.precio = Convert.ToDouble(f[4]);

            return p;
        }
    }
}
