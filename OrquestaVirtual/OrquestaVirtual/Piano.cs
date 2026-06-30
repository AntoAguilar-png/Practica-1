using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrquestaVirtual
{
    public class Piano : Instrumento
    {
        private int numeroteclas;

        public int NumeroTeclas
        {
            get { return numeroteclas; }
            set { numeroteclas = value; }
        }

        public override string TocarNota()
        {
            return $"{Modelo} toca nota. Numero de Teclas: {NumeroTeclas}";
        }
    }
}
