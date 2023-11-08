using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace EntityLayer.Entities
{
    public class Advert
    {
        public Advert()
        {
            Images = new List<Images>();
        }
        [Key]
        public int AdvertID { get; set; } //İlan ID

        public string AdvertTitle { get; set; } //İlan Başlığı

        public string Description { get; set; } //İlan Açıklaması

        public double Price { get; set; } // İlan Fİyatı

        public string Garage { get; set; } //garaj var mı

        public bool Garden { get; set; } //Bahçe var mı

        public bool Fireplace { get; set; } //Şömine var mı

        public bool Furniture { get; set; } // Mobilya var mı

        public bool Pool { get; set; } //Havuz var mı

        public bool Teras { get; set; } //Teras var mı

        public bool AirCordinator { get; set; } //Klima

        public bool NumberOfRooms { get; set; } //Kaç Oda

        public int BathroomNumbers { get; set; } //Banyo Sayısı

        public bool Credid { get; set; } //Krediye uygun mu

        public int Area { get; set; } //Kaç metre kare 

        public DateTime AdvertDate { get; set; } // Eklendiği tarih

        public int Floor { get; set; }  //Kaç Katlı
        
        public string PhoneNumbers { get; set; } // Telefon numarası

        public string Address { get; set; } //İlan Adresi

        public int CityID { get; set; } //Şehir

        public int DistrinctID { get; set; } //Semt

        public int NeighbourhoodID { get; set; } //Mahalle

        public int SituationID { get; set; } //İLan durumu 

        public int TypId { get; set; } //Tipi

        public string UserAdminID { get; set; }

        public bool Status { get; set;} //İlan AKtif mi Pasif mi

        [NotMapped]
        public IEnumerable <IFormFile> Image { get; set; } // Resim dosyası

        public virtual  Neighbourhood Neighbourhood{ get; set; }

        public virtual Type Type { get; set; }

        public virtual UserAdmin UserAdmin { get; set; }

        public virtual List<Images> Images { get; set; }

      
    }
}
