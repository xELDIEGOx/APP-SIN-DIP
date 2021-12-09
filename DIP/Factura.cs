using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Factura : DocumentoContable
    {
        //Cargamos los datos ingresados estáticamente en cada una de las propiedades de la clase 
        //Utiliza los mismos atributos ingresados para enviar los datos al constructor de DocumentoContable
        public Factura (int num, DateTime fecha, double importe) : base(num, fecha, importe)
        {
            Num = num;
            Fecha = fecha;
            Importe = importe; 
        }
        // Método polimórfico creado en la clase abstracta DocumentoContable
        public override double Total()
        {
            return Importe * 1.21;
        }
    }
}
