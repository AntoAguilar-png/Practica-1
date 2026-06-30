using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Juguete> Juguetes = new List<Juguete>();

            Juguetes.Add(new Muñeca() { NumeroSerie = 11, MaterialCabello = "Plastico"});
            Juguetes.Add(new AutoControl() { NumeroSerie = 12, Frecuencia = 50 });

            Console.WriteLine("Fábrica de Juguetes Automatizada");
            Console.WriteLine("-----------------------------------");


            foreach (var Juguete in Juguetes)
            {
                Console.WriteLine(Juguete.ProbarJuguete());
            }
    }
}}
