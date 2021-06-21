using MerkezKur.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MerkezKur.Business.Abstract
{
    public interface IKurlarService
    {
        List<Kurlar> GetKurlars();

        List<Kurlar> CreateKurlar(List<Kurlar> kurlars);

        List<Kurlar> GetUIData(string Code);
        
        //Kurlar CreateKurlar(Kurlar kurlar);



    }
}
