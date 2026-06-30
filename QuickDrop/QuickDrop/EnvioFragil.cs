using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDrop
{
    public class EnvioFragil : Envio
    {
        private string materialproteccion;

        public string MaterialProteccion
        {
            get { return materialproteccion; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    materialproteccion = value;
            }
        }

        public override string ProcesarEntrega()
        {
            return $" Entrega a: {Direccion}. Material de Proteccion: {MaterialProteccion}.";
        }
    }
}
