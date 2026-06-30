using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrimorioMágico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hechizo> Hechizos = new List<Hechizo>();

            Hechizos.Add(new BolaFuego() { Encantamiento = "Aspecto de Fuego", Temperatura = 200});
            Hechizos.Add(new EscudoHielo() { Encantamiento = "Filo", GrosorCapaz = 100 });

            foreach (var Hechizo in Hechizos)
            {
                Console.WriteLine(Hechizo.Lanzar());
            }

            Console.ReadLine();
        }
    }
}
