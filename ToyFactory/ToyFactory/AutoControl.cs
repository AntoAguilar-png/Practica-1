using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    public class AutoControl : Juguete
    {
        private int frecuencia;

        public int Frecuencia
        {
            get { return frecuencia; }
            set { frecuencia = value; }
        }

        public override string ProbarJuguete()
        {
            return $"Numero de Serie del Juguete: {NumeroSerie}. Frecuencia del Juguete: {Frecuencia}";
        }
    }
}
