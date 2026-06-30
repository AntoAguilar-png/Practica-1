using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creamos la Lista
            List<Plato> Platos = new List<Plato>();

            Platos.Add(new Pizza { NombrePlato = "Pizza Muzzarela", TipoMasa = "Masa Madre" });
            Platos.Add(new Ensalada { NombrePlato = "Ensalada Cesar", TipoAderezo = "Cesar" });

            //Recorremos la Lista

            foreach (var Plato in Platos)
            {
                Console.WriteLine(Plato.Preparar());
            }


        }
    }
}
