using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pizza.Models
{
    public class Pracownik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPracownik { get; set; }
        public string Imie { get; set; }
        public int Wypłata { get; set; }
        public virtual ICollection<Restauracja> Restauracje { get; set; }
    }
}