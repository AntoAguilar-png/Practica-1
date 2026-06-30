using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class LamparaInteligente : Dispositivo
    {
        private string colorled;

        public string ColorLed
        {
            get { return colorled; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    colorled = value;
            }
        }
        public override string EjecutarFuncion()
        {
            return $"{Habitacion} ejecuta nota. Color de la Led: {ColorLed}";

        }
        
    }
}
