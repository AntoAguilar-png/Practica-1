using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos la Lista
            List<Vehiculo> Vehiculos = new List<Vehiculo>();

            Vehiculos.Add (new AutoElectrico { Marca = "Toyota", Autonomia = 50 });
            Vehiculos.Add(new Camioneta { Marca = "Mercedes", Traccion4x4 = true });

            //Recorremos la Lista

            foreach (var Vehiculo in Vehiculos) 
            {
                Console.WriteLine(Vehiculo.Arrancar());
            }

        }
    }
}
