using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Remito
    {
        //Propiedades de la clase Remito
        public int Num { get; set; }
        public DateTime Fecha { get; set; }
        public double CantBultos { get; set; }

        //Cargamos los datos ingresados estáticamente en cada una de las propiedades de la clase
        public Remito(int num,DateTime fecha, int cantBultos)
        {
            Num = num;
            Fecha = fecha;
            CantBultos = cantBultos;
        }
    }
}
