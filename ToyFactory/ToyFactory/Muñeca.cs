using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    public class Muñeca : Juguete
    {
        private string materialcabello;

        public string MaterialCabello
        {
            get {  return materialcabello; }
            set
            {
                if(!String.IsNullOrEmpty(value))
                    materialcabello = value;

            }
        }

        public override string ProbarJuguete()
        {
            return $"Numero de Serie del Juguete: {NumeroSerie}. Material de Cabello: {MaterialCabello}";
        }
    }
}
