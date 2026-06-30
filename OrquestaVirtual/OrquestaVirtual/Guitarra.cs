using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrquestaVirtual
{
    public class Guitarra  : Instrumento
    {
        private int numerocuerdas;

        public int NumeroCuerdas
        {
            get { return numerocuerdas; }
            set { numerocuerdas = value; }
        }

        public override string TocarNota()
        {
            return $"{Modelo} toca nota. Numero de Cuerdas: {NumeroCuerdas}";
        }

    }
}
