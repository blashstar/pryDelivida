using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDelivida
{
    class Cliente
    {
        public string nombre;
        public string dni;
        public int edad;
        public double estatura;
        public double peso;

        public double obtenerIMC()
        {
            double imc;

            imc = peso / (estatura * estatura);

            return Math.Round(imc,2);
        }

        public string obtenerClasificacion()
        {
            string clasificacion;

            double imc = obtenerIMC();

            if (imc < 18.5)
            {
                clasificacion = "Bajo Peso";
            }
            else if (imc < 25)
            {
                clasificacion = "Normal";
            }
            else if (imc < 30)
            {
                clasificacion = "Sobrepeso";
            }
            else
            {
                clasificacion = "Obesidad";
            }

            return clasificacion;
        }
    }
}
