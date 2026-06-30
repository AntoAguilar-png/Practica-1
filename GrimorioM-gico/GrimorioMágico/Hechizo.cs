using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrimorioMágico
{
    public class Hechizo
    {
        private string encantamiento;

        public string Encantamiento
        {
            get { return encantamiento; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    encantamiento = value;
            }
        }

        public virtual string Lanzar()
        {
            return $"Lanzamiento: {Encantamiento}";
        }
    }
}
