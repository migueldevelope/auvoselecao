using AuvoSelecao.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace AuvoSelecao.Controllers
{

    public class HomeController : Controller
    {
        private readonly IServicePrevisaoClima _service;
        private readonly IServiceCidade _serviceCidade;

        //public HomeController(IServicePrevisaoClima service, IServiceCidade serviceCidade)
        public HomeController()
        {
            //_service = service;
            //_serviceCidade = serviceCidade;
        }

        
        
        [HttpGet]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Index()
        {
            var model = _service.ListCidadesFrias();


            return View(model);
        }

        /*//
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }*/


    }
}