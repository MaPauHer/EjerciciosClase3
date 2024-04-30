using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_1
{
    public abstract class Vehiculo
    {
        public string? Marca { set; get; }
        public string? Modelo { set; get; }

        public abstract void ImprimirDatosVehiculo();
    }
}
