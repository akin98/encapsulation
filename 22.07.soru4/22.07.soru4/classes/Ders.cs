using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._07.soru4.classes
{
    public class Ders
    {
        [Key]
        public int Dersid { get; set; }
        public string Dersadi { get; set; }
    }
}
