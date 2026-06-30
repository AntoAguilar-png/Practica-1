using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class AspiradoraRobot : Dispositivo 
    {
        private int capacidadtanque;
        public int CapacidadTanque
        {
            get { return capacidadtanque; }
            set { capacidadtanque = value; }
        }

        public override string EjecutarFuncion()
        {
            return $"{Habitacion} ejecuta funcion. Capacidad del Tanque: {CapacidadTanque}";
        }

    }
}
