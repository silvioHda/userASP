using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserASP.Models;

namespace UserASP.Controllers
{
    public class ClientesController : Controller
    {
        private EmpDbContext db = new EmpDbContext();

        public static List<Cliente> empList = new List<Cliente> {
             new Cliente{
                    ID=1,
                    nombre="Silvio",
                    fechaAlta=DateTime.Parse(DateTime.Today.ToString()),
                    edad = 22
                },
                new Cliente{
                    ID=2,
                    nombre="Luis",
                    fechaAlta =DateTime.Parse(DateTime.Today.ToString()),
                    edad=35
                }
        };

        // GET: Clientes
        public ActionResult Index()
        {
            var clientes = from e in db.clientes
                           orderby e.ID
                           select e;
            return View(clientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Cliente emp)
        {
            try
            {
                // TODO: Add insert logic here
                db.clientes.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            //List<Cliente> empLista = empList;
            var clientes = db.clientes.Single(m => m.ID == id);
            return View(clientes);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var clientes = db.clientes.Single(m => m.ID == id);
                if (TryUpdateModel(clientes))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(clientes);
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]

        public List<Cliente> listaClientes() {
            return new List<Cliente> {
                new Cliente{
                    ID=1,
                    nombre="Silvio",
                    fechaAlta=DateTime.Parse(DateTime.Today.ToString()),
                    edad = 22
                },
                new Cliente{
                    ID=2,
                    nombre="Luis",
                    fechaAlta =DateTime.Parse(DateTime.Today.ToString()),
                    edad=35
                }
            };
        }

    }
}
