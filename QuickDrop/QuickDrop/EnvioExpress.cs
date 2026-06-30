using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDrop
{
    public class EnvioExpress : Envio
    {
        private int tiempolimitehora;

        public int TiempoLimiteHora
        {
            get { return tiempolimitehora; }
            set { tiempolimitehora = value; }
        }

        public override string ProcesarEntrega()
        {
            return $" Entrega a: {Direccion}. Tiempo de llegada: {TiempoLimiteHora}.";
        }

    }
}
