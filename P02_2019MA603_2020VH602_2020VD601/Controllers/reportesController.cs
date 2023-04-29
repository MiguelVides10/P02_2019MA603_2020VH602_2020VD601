using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P02_2019MA603_2020VH602_2020VD601.Models;

namespace P02_2019MA603_2020VH602_2020VD601.Controllers
{
    public class reportesController : Controller
    {
        private readonly casosCovidContext _casosCovidContext;

        public reportesController(casosCovidContext casosCovidContext)
        {
            _casosCovidContext = casosCovidContext;
        }

        public IActionResult Index()
        {
            var listadoDeptos = (from d in _casosCovidContext.departamentos select d).ToList();
            ViewData["listaDepartamentos"] = new SelectList(listadoDeptos, "id_departamento", "departamento");

            var listadoGeneros = (from g in _casosCovidContext.generos select g).ToList();
            ViewData["listaGeneros"] = new SelectList(listadoGeneros, "id_genero", "genero");

            var listadoReportes = (from r in _casosCovidContext.reportes join
                                   d in _casosCovidContext.departamentos on r.id_departamento equals d.id_departamento
                                   join g in _casosCovidContext.generos on r.id_genero equals g.id_genero
                                   select new
                                   {
                                       departamento = d.departamento,
                                       genero = g.genero,
                                       confirmados = r.confirmados,
                                       recuperados = r.recuperados,
                                       fallecidos = r.fallecidos
                                   }).ToList();
            ViewData["listaReportes"] = listadoReportes;
            return View();
        }

        public IActionResult CrearReporte(reportes nuevoReporte)
        {
            _casosCovidContext.Add(nuevoReporte);
            _casosCovidContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
