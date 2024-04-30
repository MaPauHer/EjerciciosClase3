using Clase3.Ejercicio_1;
using Clase3.Ejercicio_2;
using System.Drawing;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio_1


            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de Vehiculo

            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del
            //Vehiculo independientemente de que si es una moto o un auto 

            //Uso
            //ImprimirDatosVehiculo(moto);
            //ImprimirDatosVehiculo(auto);

            Auto Auto1 = new Auto();
            Auto1.Modelo = "Renegade";
            Auto1.Marca = "Jeep";
            Auto1.Puertas = 5;

            Moto Moto1 = new Moto();
            Moto1.Modelo = "Zanella";
            Moto1.Marca = "RX 150";

            //Moto1.ImprimirDatosVehiculo();
            //Auto1.ImprimirDatosVehiculo();

            ImprimirDatosVehiculo(Moto1);
            ImprimirDatosVehiculo(Auto1);

            #endregion


            #region Ejercicio_2
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca


            Console.WriteLine("\n\nListado libros de la biblioteca");
            Console.WriteLine("----------------------------------");

            Biblioteca biblioteca1 = new Biblioteca();
            List<String> listadoLibros = biblioteca1.ObtenerTotalLibros();

            foreach (string Titulo in listadoLibros)
            {
                Console.WriteLine($"-- {Titulo}");
            }

            #endregion

            Console.ReadKey();
        }

        static void ImprimirDatosVehiculo(Vehiculo vehiculo)
        {
            vehiculo.ImprimirDatosVehiculo();
        }

    }
}