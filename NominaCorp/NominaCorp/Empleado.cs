using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaCorp
{
    public class Empleado
    {
        private int idempleado;

        public int IdEmpleado
        {
            get { return idempleado; }
            set { idempleado = value; }

        }

        public virtual string Trabajo()
        {
            return $"Trabajador: {IdEmpleado}";
        }
    }
}
