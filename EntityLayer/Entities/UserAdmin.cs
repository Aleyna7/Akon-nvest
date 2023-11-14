using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EntityLayer.Entities
{
    public class UserAdmin : IdentityUser
    {
        public string FullName { get; set; }

        // Diğer özellikleri ekleyebilirsiniz

        public virtual List<Advert> Adverts { get; set; }
    }
}
