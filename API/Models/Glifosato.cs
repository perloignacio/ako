using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Glifosato
    {
        public decimal volumen { get; set; }
        public decimal dureza { get; set; }
        public decimal costo { get; set; }
        public decimal dosis { get; set; }
        public decimal porinactivacion { get; set; }
        public decimal valinactivacion { get; set; }
        public decimal perdida { get; set; }
        public const decimal villaseca= 0.00047M;
    }
}