using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDrop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos la Lista

            List<Envio> Envios = new List<Envio>();

            Envios.Add(new EnvioFragil() { Direccion = "Nazarre y Campana", MaterialProteccion = "Papel Burbuja"});
            Envios.Add(new EnvioExpress() { Direccion = "Tortolo 123", TiempoLimiteHora = 10 });

            foreach (var Envio in Envios)
            {
                Console.WriteLine(Envio.ProcesarEntrega());
            }

            Console.ReadLine();


        }
    }
}
