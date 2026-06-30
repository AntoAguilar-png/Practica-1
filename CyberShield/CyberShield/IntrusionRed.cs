using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberShield
{
    public class IntrusionRed : Alerta
    {
        private string iporigen;
        
        public string IpOrigen
        {
            get { return iporigen; }
            set
            {
                if ( !String.IsNullOrEmpty(value))
                    iporigen = value;
            }
        }

        public override string DispararProtocolo()
        {
            return $"Codigo: {Codigo}. Ip Origen: {IpOrigen}";
        }
    }
}
