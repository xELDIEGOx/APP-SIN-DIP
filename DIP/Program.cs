using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos los objetos e inicializamos con datos estáticos para cada clase  (Factura,NotaCredito,Remito,FacturaLuz,Municipal)
            
            Factura factura = new Factura(2002,DateTime.Now,3030.520);
            NotaCredito notaCredito = new NotaCredito(111, DateTime.Now,256.01);
            Remito remito = new Remito(223, DateTime.Now, 334);
            FacturaLuz facturaLuz = new FacturaLuz(445, "codigoPago001");
            Municipal municipal = new Municipal(556, "partida66778899");

            //Creamos el objeto de la clase impresora, pasamos los datos y procede a imprimir desde la clase Impresora por medio de sus métodos
            Impresora impresora = new Impresora();
            impresora.Imprimir(factura);
            impresora.Imprimir(notaCredito);
            impresora.Imprimir(remito);
            impresora.Imprimir(facturaLuz);
            impresora.Imprimir(municipal);

            Console.Read();
        }
    }
}
