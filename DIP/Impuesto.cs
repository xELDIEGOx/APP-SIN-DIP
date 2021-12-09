using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Impuesto
    {
        //Propiedad de la clase Impuesto
        public double Importe { get; set; }
        //Cargamos el dato ingresado estáticamente "importe" en la propiedad de la clase
        public Impuesto (double importe)
        {
            Importe = importe;
        }

    }
}
