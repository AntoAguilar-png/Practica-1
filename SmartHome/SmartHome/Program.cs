using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear la Lista
            List<Dispositivo> Dispositivos = new List<Dispositivo>();

            Dispositivos.Add( new AspiradoraRobot { Habitacion = "Pieza Pili", CapacidadTanque = 100,});
            Dispositivos.Add(new LamparaInteligente { Habitacion = "Living", ColorLed = "Azul" });
            Dispositivos.Add(new LamparaInteligente { Habitacion = "Cocina", ColorLed = "Blanca" });

            //Recorre la Lista
            foreach (var Dispositivo in Dispositivos)
            {
                Console.WriteLine(Dispositivo.EjecutarFuncion());
               
            }
            Console.ReadKey();
        }
    }
}
