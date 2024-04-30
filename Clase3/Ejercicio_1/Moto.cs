using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_1
{
    internal class Moto: Vehiculo
    {
        public override void ImprimirDatosVehiculo()
        {
            Console.WriteLine("\nDatos de la MOTO");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");             
        }
    }
}
