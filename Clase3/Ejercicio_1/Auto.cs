using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_1
{
    internal class Auto : Vehiculo
    {
        public int Puertas { get; set; }
        public override void ImprimirDatosVehiculo()
        {
            Console.WriteLine("\nDatos de la AUTO");
            Console.WriteLine("---------------------");
            Console.WriteLine($" Marca: {Marca}");
            Console.WriteLine($" Modelo: {Modelo}");
            Console.WriteLine($" Puertas: {Puertas}");
        }
    }
}
