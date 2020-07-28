using GalenortWebApp.Models.CentroAtencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GalenortWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //public async Task<ActionResult> CentroAtencion(string prestador, int? page, string cadenaBuscar, string establecimientoBuscar)
        //{
        //    var pageNumber = (page ?? 1);

        //    ViewBag.FilterValue = cadenaBuscar;

        //   var _prestador = await _prestadorServicio.Obtener(prestador, cadenaBuscar, establecimientoBuscar);

        //    return View(new CentroAtencionViewModel
        //    {
               
        //        Centros = await _prestador
        //            .OrderByDescending(x => x.FechaDesde)
        //            .Select(s => new CentroAtencionViewModel
        //            {
        //                CentroAtencionId = s.Id,
        //                Prestador = s.Prestador,
        //                Horario = s.Horario.ToShortDateString(),
        //                Dias = s.Dias.ToShortDateString(),
        //                Establecimiento = s.Establecimiento,
        //            }).ToPagedListAsync(pageNumber, 10)
        //    });
        //}
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Planes()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Afiliado()
        {

            return View();
        }

    }
}