using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKitchen
{
    public class Plato
    {
        private string nombreplato;

        public string NombrePlato
        {
            get { return nombreplato; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    nombreplato = value;
            }
        }
        public virtual string Preparar()
        {
            return $"Se comenzo la prepacion de: {NombrePlato}";
        }
            
    }
}
