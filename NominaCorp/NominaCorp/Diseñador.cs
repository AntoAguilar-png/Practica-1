using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaCorp
{
    public class Diseñador : Empleado
    {
        private string herramientafavorita;

        public string HerramientaFavorita
        {
            get {  return herramientafavorita; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    herramientafavorita = value;
            }
        }

        public override string Trabajo()
        {
            return $"Trabajador: {IdEmpleado}. Herramienta Favorita: {HerramientaFavorita}"; 
        }
    }
}
