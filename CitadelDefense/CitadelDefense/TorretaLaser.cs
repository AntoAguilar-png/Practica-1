using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitadelDefense
{
    public class TorretaLaser : Torreta
    {
        private int cargarbateria;

        public int CargarBateria
        {
            get {  return cargarbateria; }
            set { CargarBateria =  value; }
        }

        public override string Disparar()
        {
            return $"Ubicación de la torreta: {Ubicacion}. Cargar Bateria: {CargarBateria}";
        }
    }
}
