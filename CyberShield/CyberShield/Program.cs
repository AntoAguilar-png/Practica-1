using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberShield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alerta> Alertas = new List<Alerta>();

            Alertas.Add(new IntrusionRed(){Codigo = 1234567, IpOrigen = "123.1.123.1" });
            Alertas.Add(new MalwareDetectado() { Codigo = 9876543, RutaArchivo = "C:.Usuarios.Anto.Documentos.archivo.pdf" });

            Console.WriteLine("Sistema de Alertas de Ciberseguridad");

            foreach (var Alerta in Alertas)
            {
                Console.WriteLine(Alerta.DispararProtocolo());
            }
        }
    }
}
