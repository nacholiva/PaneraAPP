using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class Reserva
    {
        public int ID { get; set; }
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        public string Producto { get; set; }
        public string Contacto { get; set; }
        public string Metodopago { get; set; }
        public string Pagado { get; set; }
        public string Entregado { get; set; }
    }
}
