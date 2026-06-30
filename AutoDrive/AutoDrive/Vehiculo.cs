using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDrive
{
    public class Vehiculo
    {
        private string marca;

        public string Marca
        {
            get { return marca; }
            set { if (!String.IsNullOrEmpty(value))
                    marca = value;
            }
        }

        public virtual string Arrancar()
        {
            return $"{Marca} esta arrancando";
        }
    }
}
