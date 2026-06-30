using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDrop
{
    public class Envio
    {
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    direccion = value;
            }
        }

        public virtual string ProcesarEntrega()
        {
            return $" Entrega a: {Direccion}";  
        }
    }
}
