using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDrive
{
    public class Camioneta : Vehiculo
    {
        private bool traccion4x4;

        public bool Traccion4x4
        {
            get { return traccion4x4; }
            set { traccion4x4 = value; }
        }

        public override string Arrancar()
        {
            return $"La camioneta {Marca} arranco. 4x4: {Traccion4x4}";
        }
    }
}
