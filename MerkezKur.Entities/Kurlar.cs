using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MerkezKur.Entities
{
    public class Kurlar
    {
        public Kurlar(int id, string name, string code, string crossRateName, double forexBuying, double forexSelling, double banknoteBuying, double banknoteSelling, string datetimeKurGet)
        {
            this.id = id;
            Name = name;
            Code = code;
            CrossRateName = crossRateName;
            ForexBuying = forexBuying;
            ForexSelling = forexSelling;
            BanknoteBuying = banknoteBuying;
            BanknoteSelling = banknoteSelling;
            DatetimeKurGet = datetimeKurGet;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CrossRateName { get; set; }
        public double ForexBuying { get; set; }
        public double ForexSelling { get; set; }
        public double BanknoteBuying { get; set; }
        public double BanknoteSelling { get; set; }
        public string DatetimeKurGet { get; set; }
    }
}
