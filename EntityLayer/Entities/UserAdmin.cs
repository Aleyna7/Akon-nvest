using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Entities
{
    public class UserAdmin : IdentityUser
    {
        public string FullName { get; set; }

        // Diğer özellikleri ekleyebilirsiniz

        public virtual List<Advert> Adverts { get; set; }
    }
}
