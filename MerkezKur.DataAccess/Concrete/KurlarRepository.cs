using MerkezKur.DataAccess.Abstract;
using MerkezKur.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace MerkezKur.DataAccess.Concrete
{
    public class KurlarRepository : IKurlarRepository
    {


        public List<Kurlar> CreateKurlar(List<Kurlar> kurlars)
        {
            using (var krs = new MerkezKurDbContext())
            {
                for (int i = 0; i < kurlars.Count; i++)
                {
                    krs.Add(kurlars[i]);
                    krs.SaveChanges();
                }



            }

            return kurlars;
        }

        public List<Kurlar> GetUIData(string Code)
        {
            List<Kurlar> kurveri = new List<Kurlar>();
            using (var krsveri = new MerkezKurDbContext())
            {
                kurveri= krsveri.Kurlars.Where(x=>x.Code == Code).ToList();
            }
            return kurveri;
        }

        List<Kurlar> IKurlarRepository.GetKurlars()
        {
            List<Kurlar> curs1 = new List<Kurlar>();
            List<Kurlar> curs2 = new List<Kurlar>();
            List<Kurlar> curs3 = new List<Kurlar>();
            List<Kurlar> curs4 = new List<Kurlar>();
            List<Kurlar> curs5 = new List<Kurlar>();
            List<Kurlar> curs6 = new List<Kurlar>();
            List<Kurlar> curs7 = new List<Kurlar>();
            List<Kurlar> curs8 = new List<Kurlar>();
            List<Kurlar> curs9 = new List<Kurlar>();
            List<Kurlar> curs10 = new List<Kurlar>();
            List<Kurlar> curs11 = new List<Kurlar>();
            List<Kurlar> curs12 = new List<Kurlar>();
            List<Kurlar> curs13 = new List<Kurlar>();
            List<Kurlar> curs14 = new List<Kurlar>();
            List<Kurlar> curs15 = new List<Kurlar>();
            List<Kurlar> curs16 = new List<Kurlar>();
            List<Kurlar> curs17 = new List<Kurlar>();

            DateTime zamankaydır = new DateTime();
            DateTime dt_Ay = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
            DateTime dt_sımdikizaman = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            TimeSpan kalangun = dt_sımdikizaman - dt_Ay;

            //for (int i = 0; i < kalangun.TotalDays; i++)
            //{

            //    zamankaydır = dt_Ay.AddDays(i);

            //    curs1 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(zamankaydır.Year, zamankaydır.Month, zamankaydır.Day);
            //}

            curs1 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 03);
            curs2 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 04);
            curs3 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 05);
            curs4 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 06);
            curs5 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 07);
            curs6 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 10);
            curs7 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 11);
            curs8 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 17);
            curs9 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 18);
            curs10 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 20);
            curs11 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 21);
            curs12 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 24);
            curs13 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 25);
            curs14 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 26);
            curs15 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 27);
            curs16 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 28);
            curs17 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(2021, 05, 31);

            List<Kurlar> allProducts = curs1.Concat(curs2)
                                    .Concat(curs3)
                                    .Concat(curs4)
                                    .Concat(curs5)
                                    .Concat(curs6)
                                    .Concat(curs7)
                                    .Concat(curs8)
                                    .Concat(curs9)
                                    .Concat(curs10)
                                    .Concat(curs11)
                                    .Concat(curs12)
                                    .Concat(curs13)
                                    .Concat(curs14)
                                    .Concat(curs15)
                                    .Concat(curs16)
                                    .Concat(curs17)
                                    .ToList();
            //for (int i = 0; i < kalangun.TotalDays; i++)
            //{

            //    zamankaydır = dt_Ay.AddDays(i);
            //    if (zamankaydır.DayOfWeek!=DayOfWeek.Saturday ||zamankaydır.DayOfWeek!=DayOfWeek.Sunday)
            //    {
            //        curs1 = CurrenciesExchange.GetAllCurrenciesHistoricalExchangeRates(zamankaydır.Year, zamankaydır.Month, zamankaydır.Day);
            //    }


            //}




            return allProducts;
        }

        public static class CurrenciesExchange
        {
            public static List<Kurlar> GetAllCurrenciesHistoricalExchangeRates(int Year, int Month, int Day)
            {
                try
                {
                    string SYear = String.Format("{0:0000}", Year);
                    string SMonth = String.Format("{0:00}", Month);
                    string SDay = String.Format("{0:00}", Day);



                    return GetCurrencyRates("https://www.tcmb.gov.tr/kurlar/" + SYear + SMonth + "/" + SDay + SMonth + SYear + ".xml");
                }
                catch (Exception ex)
                {
                    throw new Exception("resmi tatil veya haftasonu!");
                }
            }
            private static List<Kurlar> GetCurrencyRates(string Link)
            {
                try
                {

                    //XmlReaderSettings settings = new XmlReaderSettings();
                    //settings.DtdProcessing = DtdProcessing.Parse;
                    //settings.ValidationType = ValidationType.DTD;

                    //settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
                    //settings.XmlResolver = new XmlUrlResolver();

                    //XmlDocument doc = new XmlDocument();
                    //XmlTextReader reader = new XmlTextReader(Link);

                    //doc.Load(reader);

                    List<Kurlar> ExchangeRates = new List<Kurlar>();
                    XmlTextReader rdr = new XmlTextReader(Link);
                    XmlDocument myxml = new XmlDocument();

                    myxml.Load(Link);

                    XmlNode tarih = myxml.SelectSingleNode("/Tarih_Date/@Tarih");
                    XmlNodeList mylist = myxml.SelectNodes("/Tarih_Date/Currency");
                    XmlNodeList adi = myxml.SelectNodes("/Tarih_Date/Currency/Isim");
                    XmlNodeList kod = myxml.SelectNodes("/Tarih_Date/Currency/@Kod");
                    XmlNodeList doviz_alis = myxml.SelectNodes("/Tarih_Date/Currency/ForexBuying");
                    XmlNodeList doviz_satis = myxml.SelectNodes("/Tarih_Date/Currency/ForexSelling");
                    XmlNodeList efektif_alis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteBuying");
                    XmlNodeList efektif_satis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteSelling");


                    for (int i = 0; i < adi.Count; i++)
                    {
                        Kurlar cur1 = new Kurlar(
                            0,
                            adi.Item(i).InnerText.ToString(),
                            kod.Item(i).InnerText.ToString(),
                            kod.Item(i).InnerText.ToString() + "/TRY",
                           (String.IsNullOrWhiteSpace(doviz_alis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(doviz_alis.Item(i).InnerText.ToString().Replace(".", ",")),
                            (String.IsNullOrWhiteSpace(doviz_satis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(doviz_satis.Item(i).InnerText.ToString().Replace(".", ",")),
                           (String.IsNullOrWhiteSpace(efektif_alis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(efektif_alis.Item(i).InnerText.ToString().Replace(".", ",")),
                            (String.IsNullOrWhiteSpace(efektif_satis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(efektif_satis.Item(i).InnerText.ToString().Replace(".", ",")),
                            tarih.InnerText.ToString()
                            );


                        //Kurlar cur = new Kurlar(
                        //    adi.Item(i).InnerText.ToString(),
                        //    kod.Item(i).InnerText.ToString(),
                        //    kod.Item(i).InnerText.ToString() + "/TRY",
                        //    (String.IsNullOrWhiteSpace(doviz_alis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(doviz_alis.Item(i).InnerText.ToString().Replace(".", ",")),
                        //    (String.IsNullOrWhiteSpace(doviz_satis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(doviz_satis.Item(i).InnerText.ToString().Replace(".", ",")),
                        //    (String.IsNullOrWhiteSpace(efektif_alis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(efektif_alis.Item(i).InnerText.ToString().Replace(".", ",")),
                        //    (String.IsNullOrWhiteSpace(efektif_satis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(efektif_satis.Item(i).InnerText.ToString().Replace(".", ",")),
                        //     tarih.InnerText.ToString()

                        //    );

                        ExchangeRates.Add(cur1);
                    }
                    return ExchangeRates;
                    //if (adi.Count != 0)
                    //{

                    //XmlNode tarih = myxml.SelectSingleNode("/Tarih_Date/@Tarih");
                    //XmlNodeList mylist = myxml.SelectNodes("/Tarih_Date/Currency");
                    //XmlNodeList adi = myxml.SelectNodes("/Tarih_Date/Currency/Isim");
                    //XmlNodeList kod = myxml.SelectNodes("/Tarih_Date/Currency/@Kod");
                    //XmlNodeList doviz_alis = myxml.SelectNodes("/Tarih_Date/Currency/ForexBuying");
                    //XmlNodeList doviz_satis = myxml.SelectNodes("/Tarih_Date/Currency/ForexSelling");
                    //XmlNodeList efektif_alis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteBuying");
                    //XmlNodeList efektif_satis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteSelling");





                    //}
                    //else
                    //{
                    //    for (int i = 0; i < adi.Count; i++)
                    //    {
                    //        Kurlar CUR1 = new Kurlar(adi.Item(i).InnerText.ToString(),
                    //            kod.Item(i).InnerText.ToString(),
                    //            kod.Item(i).InnerText.ToString() + "/TRY",
                    //            (String.IsNullOrWhiteSpace(doviz_alis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(doviz_alis.Item(i).InnerText.ToString().Replace(".", ",")),
                    //            (String.IsNullOrWhiteSpace(doviz_satis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(doviz_satis.Item(i).InnerText.ToString().Replace(".", ",")),
                    //            (String.IsNullOrWhiteSpace(efektif_alis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(efektif_alis.Item(i).InnerText.ToString().Replace(".", ",")),
                    //            (String.IsNullOrWhiteSpace(efektif_satis.Item(i).InnerText.ToString())) ? 0 : Convert.ToDouble(efektif_satis.Item(i).InnerText.ToString().Replace(".", ",")));
                    //        ExchangeRates.Add(CUR1);
                    //    }


                    //}





                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            private static bool _Flag = false;
            private static void ValidationCallBack(object sender, ValidationEventArgs e)
            {


                _Flag = true;

            }





        }
    }
}
