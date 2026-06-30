using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKitchen
{
    public class Pizza : Plato
    {
        private string tipomasa;
        
        public string TipoMasa
        {
            get { return tipomasa; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    tipomasa = value;
            }
        }

        public override string Preparar()
        {
            return $"Se comenzo la prepacion de: {NombrePlato}. Tipo Masa: {TipoMasa}";
        }

    }
}
