using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Neighbourhood
    {
        [Key]
        public int NeighbourhoodId { get; set; } //Mahalle ID

        public string NeighbourhoodName { get; set; }  //  Mahalle Adı

        public bool Status { get; set; } // durumu

        public int DistrictId { get; set; }

        public virtual District District { get; set; }
    }
}

 