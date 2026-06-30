using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Dispositivo
    {
        private string habitacion;

        public string Habitacion
        {
            get { return habitacion; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    habitacion = value;
            }
        }
        public virtual string EjecutarFuncion()
        {
            return $"{Habitacion} ejecuta funcion.";
        }

    }
}
