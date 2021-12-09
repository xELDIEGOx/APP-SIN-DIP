using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class FacturaLuz : Impuesto
    {
        //Propiedad de la clase FacturaLuz
        public string CodigoPago { get; set; }
        //Cargamos el dato ingresado estáticamente "codigoPago"en la propiedad de la clase
        public FacturaLuz (double importe, string codigoPago): base(importe)
        {
            CodigoPago = codigoPago;
        }
    }
}
