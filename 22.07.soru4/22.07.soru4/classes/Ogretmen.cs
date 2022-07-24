using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._07.soru4.classes
{
    public class Ogretmen

    {
        [Key]
        // KEY KULLANMANIN amacı primary key yapmak
        public int Ogretmenid { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int DersID { get; set; }
        public virtual Ders Ders { get; set; }
    }
}
