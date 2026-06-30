using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaCorp
{
    public class Programador : Empleado
    {
        private string lenguajeprincipal;

        public string LenguajePrincipal
        {
            get { return lenguajeprincipal; }   
            set
            {
                if (!String.IsNullOrEmpty(value))
                lenguajeprincipal = value;
            }
        }

        public override string Trabajo()
        {
            return $"Trabajador: {IdEmpleado}. Lenguaje Principal: {LenguajePrincipal}";
        }
    }
}
