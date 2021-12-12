using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PaneraAPPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Reserva
    {

        public int ID { get; set; }

        [Display(Name = "Cantidad")]
        [Range(0, 100, ErrorMessage = "Debe ingresar una cantidad válida")]
        public int Cantidad { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Producto a reservar")]
        [Required(ErrorMessage = "Debe ingresar un tipo de producto")]
        public string Producto { get; set; }
        [Display(Name = "Contacto")]
        [Required(ErrorMessage = "Debe ingresar un tipo de producto")]
        public string Contacto { get; set; }
        [Display(Name = "Método de Pago")]
        [Required(ErrorMessage = "Debe especificar método de pago")]
        public string Metodopago { get; set; }
        [Display(Name = "Pagado")]
        //[Required(ErrorMessage = "Debe especificar estado de pago")]
        public string Pagado { get; set; } = "no";
        [Display(Name = "Entregado")]
        //[Required(ErrorMessage = "Debe especificar estado de entrega")]
        public string Entregado { get; set; } = "no";
    }

    public class EFCodeFirstEntieis1 : DbContext
    {
        public DbSet<Reserva> Reserva { get; set; }

        public System.Data.Entity.DbSet<DataLibrary.Reserva> Reservas { get; set; }
    }
}