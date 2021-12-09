using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Impresora
    {
        //Maneja todos los procesos de impresión de las diferentes clases, recibiendo un objeto desde la clase program
        public void Imprimir(Factura factura)
        {
            Console.WriteLine($"IMPRIMIENDO Factura {factura.Num} del {factura.Fecha} por un importe {factura.Importe}");
        }
        public void Imprimir(NotaCredito notaCredito)
        {
            Console.WriteLine($"\nIMPRIMIENDO Nota de Crédito {notaCredito.Num} del {notaCredito.Fecha} por un importe {notaCredito.Importe}");
        }
        public void Imprimir(FacturaLuz facturaLuz)
        {
            Console.WriteLine($"\nIMPRIMIENDO Factura de luz con el código de pago N° {facturaLuz.CodigoPago} y el importe {facturaLuz.Importe}");
        }
        public void Imprimir(Municipal municipal)
        {
            Console.WriteLine($"\nIMPRIMIENDO impuesto municipal de partida {municipal.Partida} por un importe {municipal.Importe}");
        }
        public void Imprimir(ReciboSueldo reciboSueldo)
        {
            Console.WriteLine($"\nIMPRIMIENDO recibo de sueldo del legajo {reciboSueldo.Legajo} con un total de {reciboSueldo.Total}");
        }
        public void Imprimir(Remito remito)
        {
            Console.WriteLine($"\nIMPRIMIENDO recibo remito {remito.Num} del {remito.Fecha} con una cantidad de bultos igual a {remito.CantBultos}");
        }
    }
}
