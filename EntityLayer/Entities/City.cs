using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class City
    {
        [Key]
        public int CityID { get; set; } //Şehir ID

        public string CityName { get; set; }   //Şehir İsmi

        public bool Status { get; set; } //Şuan ki durumu 

        public virtual List<District> District { get; set; }

    }
}
