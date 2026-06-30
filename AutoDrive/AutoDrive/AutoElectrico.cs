using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDrive
{
    public class AutoElectrico : Vehiculo
    {
        private int autonomia;

        public int Autonomia
        {
            get { return autonomia; }
            set
            { autonomia = value; }
        }

        public override string Arrancar()
        {
            return $"El Autoelectrico {Marca} arranco. Autonomia: {Autonomia} km";
        }


    }
}
