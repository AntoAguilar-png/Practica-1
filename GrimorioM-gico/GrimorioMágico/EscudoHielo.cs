using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrimorioMágico
{
    public class EscudoHielo : Hechizo
    {
        private int grosorcapaz;

        public int GrosorCapaz
        {
            get { return grosorcapaz; }
            set { grosorcapaz = value; }
        }

        public override string Lanzar()
        {
            return $"Lanzamiento: {Encantamiento}. Grosor de Capaz: {GrosorCapaz}";
        }

    }
}
