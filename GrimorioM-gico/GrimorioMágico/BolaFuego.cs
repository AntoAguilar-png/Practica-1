using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrimorioMágico
{
    public class BolaFuego : Hechizo
    {
        private int temperatura;

        public int Temperatura
        {
            get { return temperatura; }
            set
            {
                temperatura = value;
            }
        }

        public override string Lanzar()
        {
            return $"Lanzamiento: {Encantamiento}. Temperatura de la Bola de Fuego: {Temperatura}";
        }
    }
}
