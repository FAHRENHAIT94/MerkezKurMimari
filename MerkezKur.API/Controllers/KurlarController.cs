using MerkezKur.Business.Abstract;
using MerkezKur.Business.Concrete;
using MerkezKur.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace MerkezKur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KurlarController : ControllerBase
    {
        private IKurlarService _kurlarService;

        private static List<Kurlar> _gelenKurlar;
        public KurlarController()
        {
            _kurlarService = new KurlarManage();
        }
      
        [HttpGet]
        public List<Kurlar> Get()
        {
            _gelenKurlar = _kurlarService.GetKurlars();

            return _gelenKurlar;
        }



        [HttpPost("add")]
        public IActionResult add()
        {
          
            _kurlarService.CreateKurlar(_gelenKurlar.ToList());

            return Ok();
        }

        //[HttpPost("add")]
        //public IActionResult add([FromBody] List<Kurlar> kurlar)
        //{
        //    kurlar = _gelenKurlar;

        //    _kurlarService.CreateKurlar(kurlar.ToList());


        //    return Ok("Basarılı");
        //}


        //[HttpPost("add")]
        //public IActionResult add([FromBody] Kurlar kurlar)
        //{

        //    _kurlarService.CreateKurlar(kurlar);


        //    return Ok("Basarılı");
        //}





    }
}
