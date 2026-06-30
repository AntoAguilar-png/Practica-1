using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitadelDefense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Torreta> Torretas = new List<Torreta>();

            Torretas.Add(new TorretaLaser() { Ubicacion = "Campo", CargarBateria = 400 });
            Torretas.Add(new LanzaMisiles() { Ubicacion = "Techo", MunicionRestante = 200 });

            Console.WriteLine("Simulador de Armas de Defensa");

            foreach (var Torreta in Torretas)
            {
                Console.WriteLine(Torreta.Disparar());
            }

        }
    }
}
