using MerkezKur.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MerkezKur.DataAccess.Abstract
{
    public interface IKurlarRepository
    {
        
        List<Kurlar> GetKurlars();
        List<Kurlar> CreateKurlar(List<Kurlar> kurlars);

        List<Kurlar> GetUIData(string Code);
    }
}
