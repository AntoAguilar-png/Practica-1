using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    public class Juguete
    {
        private int numeroserie;

        public int NumeroSerie
        {
            get { return numeroserie; }
            set { numeroserie = value; }

        }

        public virtual string ProbarJuguete()
        {
            return $"Numero de Serie del Juguete: {NumeroSerie}";
        }
    }

}
