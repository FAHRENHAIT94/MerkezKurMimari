using MerkezKur.Business.Abstract;
using MerkezKur.Business.Concrete;
using MerkezKur.UI1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MerkezKur.UI1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

      

        public IActionResult Index()
        {
            return View();
        }


        private IKurlarService _kurlarServicecek;
        //public JsonResult bolgegetir(string p)
        public JsonResult bolgegetir(string p)
        {

            _kurlarServicecek = new KurlarManage();

           var gelenveri= _kurlarServicecek.GetUIData(p);


            //var anabolgegetir = (from x in db.Ulkeler.ToList()
            //                     join y in db.AnaBolgeler.ToList() on x.id equals y.UlkeId
            //                     where x.id == p
            //                     select new bolge
            //                     {
            //                         id = Convert.ToInt32(y.id),
            //                         Ad = y.BolgeAdi,
            //                     }).ToList();

            
            return Json(gelenveri);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
