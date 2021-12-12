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
    public static class UsuarioProc
    {
        public static int CrearUsuario(int id, string nombre, string clave, int baguette, int hogaza)
        {
            Usuario data = new Usuario
            {
                ID = id,
                Nombre = nombre,
                Clave = clave,
                Baguette = baguette,
                Hogaza = hogaza
            };

            string sql = @"INSERT INTO usuario ([nombre], [clave], [baguette], [hogaza]) VALUES
                         (@Nombre, @Clave, @Baguette, @Hogaza);";

            return SqlDataAccess.SaveData(sql, data);
        }
        public static int EditarUsuario(int id, string nombre, string clave, int baguette, int hogaza)
        {
            Usuario data = new Usuario
            {
                ID = id,
                Nombre = nombre,
                Clave = clave,
                Baguette = baguette,
                Hogaza = hogaza
            };

            string sql = @"UPDATE reserva
                         SET [nombre] = @Nombre, [clave] = @Clave, [baguette] = @Baguette, [hogaza] = @Hogaza
                         WHERE [ID] = @ID;";

            return SqlDataAccess.SaveData(sql, data);
        }



        //public List<Reserva> MostrarReserva()
        //{
        //    List<Reserva> data = new List<Reserva>
        //    {
        //        ID = id,
        //        Cantidad = cantidad,
        //        Producto = producto,
        //        Nombre = nombre,
        //        Contacto = contacto,
        //        Metodopago = metodopago,
        //        Pagado = pagado,
        //        Entregado = entregado,
        //    };

        //    string sql = @"SELECT * FROM usuario;";

        //    return SqlDataAccess.LoadData("SELECT * FROM usuario;");
        //}
        //public static int BorrarReserva(int id)
        //{
        //    Reserva data = new Reserva
        //    {
        //        ID = id
        //    };

        //    string sql = @"DELETE FROM reserva WHERE ID = @ID;";

        //    return SqlDataAccess.SaveData(sql, data);
        //}

    }
}