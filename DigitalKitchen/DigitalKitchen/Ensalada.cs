using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKitchen
{
    public class Ensalada : Plato
    {
        private string tipoaderezo;

        public string TipoAderezo
        {
            get { return tipoaderezo; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    tipoaderezo = value;
            }
        }

        public override string Preparar()
        {
            return $"Se comenzo la prepacion de: {NombrePlato}. Tipo de Aderezo: {TipoAderezo}";
        }
    }
}
