using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angel_lab1.Models;

namespace Angel_lab1.Controllers
{
    public class NotasController : Controller
    {


        private EstuDBContex db = new EstuDBContex();





        // GET: Notas
        public ActionResult Index()
        {
            var estudiantes = from a in db.Estudiantes
                              orderby a.Nombre
                              select a;

            return View();
        }

        public ActionResult Create (Estudiante Estu)
        {
            try {

                db.Estudiantes.Add(Estu);
                db.SaveChanges();
            
            } catch { }

           // return Redirect("index");

            return View();
        }
       

        public ActionResult procesar(String Nombre, double lab1, double lab2, double lab3, double par1, double par2, double par3)
        {
          

            using (BaseDeDatosEntities1 bd = new BaseDeDatosEntities1())
            {
                TblNotasEstudiante Etd = new TblNotasEstudiante();

                Etd.Nombre = Nombre;
                Etd.Laboratorio_1 = lab1;
                Etd.Laboratorio_2 = lab2;
                Etd.Laboratorio_3 = lab3;
                Etd.Parcial_1 = par1;
                Etd.Parcial_2 = par2;
                Etd.Parcial_3 = par3;

                bd.TblNotasEstudiante.Add(Etd);

                bd.SaveChanges();

                return Redirect("Notas/segundaVista");
            }
            
        }
        public ActionResult segundaVista()
        {
            return View();
        }

       // public ActionResult registro()
        //{
          //  var notas = new TblNotasEstudiante { };

            //return View("segundaVista");
        //}
       
    }
}
