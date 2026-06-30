using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaCorp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos la Lista
            List<Empleado> Empleados = new List<Empleado>();

            Empleados.Add(new Programador { IdEmpleado = 1, LenguajePrincipal = "C#" });
            Empleados.Add(new Diseñador { IdEmpleado = 2, HerramientaFavorita = "Illustrator" });

            //Recorremos la Lista
            foreach (var Empleado in Empleados)
            {
                Console.WriteLine(Empleado.Trabajo());
            }

        }
    }
}
