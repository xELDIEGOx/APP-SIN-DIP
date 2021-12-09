using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Municipal : Impuesto
    {
        //Propiedad de la clase Municipal
        public string Partida { get; set; }
        //Cargamos el dato ingresado estáticamente "Partida" en la propiedad de la clase
        public Municipal (double importe, string partida) : base(importe)
        {
            Partida = partida;
        }
    }
}
