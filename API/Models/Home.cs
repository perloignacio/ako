using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using crmRules.Entities;
namespace API.Models
{
    public class Home
    {
        public decimal totalesta { get; set; } 
        public decimal totalako { get; set; }
        public Contactos contacto { get; set; }
        public Glifosato glifosato { get;set; }
        public Correccion correccion { get; set; }
    }
}