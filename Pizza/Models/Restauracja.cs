using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
    public enum Wielkosc
    {
        mała, średnia, duża
    }
    public class Restauracja
    {
        public int IDRestauracja { get; set; }
        public int IDPizza { get; set; }
        public int IDPracownik { get; set; }
        public Wielkosc? Wielkosc { get; set; }

        public virtual Pizza Pizza { get; set; }
        public virtual Pracownik Pracownik { get; set; }

    }
}