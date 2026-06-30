using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberShield
{
    public class Alerta
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public virtual string DispararProtocolo()
        {
            return $"Codigo: {Codigo}";
        }
    }
}
