using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitadelDefense
{
    public class Torreta
    {
        private string ubicacion;

        public string Ubicacion
        {
            get { return ubicacion; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    ubicacion = value;
            }
        }

        public virtual string Disparar()
        {
            return $"Ubicación de la torreta: {Ubicacion}";
        }
    
            
    }
}
