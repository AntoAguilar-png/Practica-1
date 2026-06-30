
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrquestaVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos la Lista

            List<Instrumento> Instrumentos = new List<Instrumento>();

            Instrumentos.Add(new Guitarra { Modelo = "Trincado", NumeroCuerdas = 50 });
            Instrumentos.Add(new Piano { Modelo = "Carito", NumeroTeclas = 50 });

            //Recorremos la Lista

            foreach(var Instrumento in Instrumentos)
            {
                Console.WriteLine(Instrumento.TocarNota());
            }

        }
    }
}
