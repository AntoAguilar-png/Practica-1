using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitadelDefense
{
    public class LanzaMisiles : Torreta
    {
        private int munisionrestante;

        public int MunicionRestante
        {
            get { return munisionrestante;}
            set { munisionrestante = value; }
        }

        public override string Disparar()
        {
            return $"Ubicación de la torreta: {Ubicacion}. Municion Restante {MunicionRestante} ";
        }
    }
}
