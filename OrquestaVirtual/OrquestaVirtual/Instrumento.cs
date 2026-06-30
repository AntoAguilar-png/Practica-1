using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrquestaVirtual
{
    public class Instrumento
    {
        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    modelo = value;
            }
        }

        public virtual string TocarNota()
        {
            return $"{Modelo} toca nota.";
        }
    }
}
