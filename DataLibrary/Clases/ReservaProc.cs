using DataLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.Clases
{
    public static class ReservaProc
    {
        public static int CrearReserva(int id, int cantidad, string producto, string nombre, string contacto, string metodopago, string pagado, string entregado)
        {
            Reserva data = new Reserva
            {
                ID = id,
                Cantidad = cantidad,
                Producto = producto,
                Nombre = nombre,
                Contacto = contacto,
                Metodopago = metodopago,
                Pagado = pagado,
                Entregado = entregado,
            };

            string sql = @"INSERT INTO reserva ([cantidad], [producto], [nombre], [contacto], [metodopago], [pagado], [entregado]) VALUES
                         (@Cantidad, @Producto, @Nombre, @Contacto, @Metodopago, @Pagado, @Entregado);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static int EditarReserva(int id, int cantidad, string producto, string nombre, string contacto, string metodopago, string pagado, string entregado)
        {
            Reserva data = new Reserva
            {
                ID = id,
                Cantidad = cantidad,
                Producto = producto,
                Nombre = nombre,
                Contacto = contacto,
                Metodopago = metodopago,
                Pagado = pagado,
                Entregado = entregado,
            };

            string sql = @"UPDATE reserva
                         SET [cantidad] = @Cantidad, [producto] = @Producto, [nombre] = @Nombre, [contacto] = @Contacto, [metodopago] = @Metodopago, [pagado] = @Pagado, [entregado] = @Entregado
                         WHERE [ID] = @ID;";

            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<Reserva> BuscarReserva(int id)
        {
            int ID = id;
            string sql = @"SELECT * FROM reserva WHERE ID =@ID);";

            return SqlDataAccess.LoadData<Reserva>(sql);
        }

    }
}