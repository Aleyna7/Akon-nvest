using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Situation
    {
        [Key]
        public int StiuationID { get; set; } //Durum ID

        public string StiuationName { get; set; }//Durum Adı

        public bool Status { get; set;} // Durum Tipi

        public virtual List<Type> Types { get; set; } //Kiralık birden fazla ev olabilir
    }
}
