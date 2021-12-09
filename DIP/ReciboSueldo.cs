using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class ReciboSueldo
    {
        //Propiedades de la clase ReciboSueldo
        public double Total { get; set; }
        public int Legajo { get; set; }

        //Cargamos los datos ingresados estáticamente en cada una de las propiedades de la clase
        public ReciboSueldo (int legajo, double total)
        {
            Legajo = legajo;
            Total = total;
        }
    }
}
