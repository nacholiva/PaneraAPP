using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using Dapper;
////using DataLibrary;
using PaneraAPPS.Models;
using static DataLibrary.Clases.ReservaProc;


namespace PaneraAPPS.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Reserva()
        {
            ViewBag.Message = "Interfaz de reservas";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Reserva(Models.Reserva model)
        {
            if (ModelState.IsValid)
            {
                int registroCreado = CrearReserva(model.ID, model.Cantidad, model.Producto, model.Nombre, model.Contacto, model.Metodopago, model.Pagado, model.Entregado);
                return RedirectToAction("Post");
            }

            return View();
        }
        //public ActionResult Post()
        //{
        //    return View();
        //}
        // POST: /Post/5
        //public ActionResult Post()
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }
        // GET: /Details/5
        public ActionResult Details(int id)
        {
            Reserva reserva = new Reserva();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MVCPaneraDB"].ConnectionString))
            {
                reserva = db.Query<Reserva>("SELECT * FROM Reserva WHERE ID =" + id, new { id }).SingleOrDefault();
            }
            return View(reserva);
        }

        // GET: /Create
        public ActionResult Create()
        {
            return RedirectToAction("Reserva");
        }

        // POST: Reserva/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: /Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: /Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Reserva model)
        {
            if (ModelState.IsValid)
            {
                int registroCreado = EditarReserva(model.ID, model.Cantidad, model.Producto, model.Nombre, model.Contacto, model.Metodopago, model.Pagado, model.Entregado);
                return RedirectToAction("Admin");
            }

            return View();
        }

        // GET: /Delete/5
        public ActionResult Delete()
        {

            return View();
        }

        // POST: /Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            Reserva reserva = new Reserva();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MVCPaneraDB"].ConnectionString))
            {
                reserva = db.Query<Reserva>("DELETE FROM Reserva WHERE ID =" + id, new { id }).SingleOrDefault();
                return RedirectToAction("Admin");
            }
            return View(reserva);
        }



    }
}