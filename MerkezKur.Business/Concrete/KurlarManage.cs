using MerkezKur.Business.Abstract;
using MerkezKur.DataAccess;
using MerkezKur.DataAccess.Abstract;
using MerkezKur.DataAccess.Concrete;
using MerkezKur.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MerkezKur.Business.Concrete
{
    public class KurlarManage : IKurlarService
    {
        public IKurlarRepository _kurlarRepository;
     

   
        public KurlarManage()
        {
            _kurlarRepository = new KurlarRepository();
        }

        public List<Kurlar> GetKurlars()
        {
            return _kurlarRepository.GetKurlars();
        }

        public List<Kurlar> CreateKurlar(List<Kurlar> kurlars)
        {
            return _kurlarRepository.CreateKurlar(kurlars);
        }

        public List<Kurlar> GetUIData(string Code)
        {
            return _kurlarRepository.GetUIData(Code);
        }
    }
}
