using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Images
    {
        [Key]
        public int ImageID { get; set; } //Resim ID

        public string ImageName { get; set; } //Resim Ad

        public bool Status { get; set; } //Aktif mi

        public int AdvertID { get; set; } // İlan ID

        public virtual Advert Advert { get; set; } // İlan ID
    }
}
