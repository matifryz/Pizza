using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
    public class Pizza
    {
        public int IDPizza { get; set; }
        public string NazwaPizza { get; set; }
        public string SkłanikiPizza { get; set; }
        public int CenaPizza { get; set; }

        public virtual ICollection<Restauracja> Restauracje { get; set; }
    }
}