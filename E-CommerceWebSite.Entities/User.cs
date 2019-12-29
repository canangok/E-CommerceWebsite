using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebSite.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Hakkımda bilgisini göstermek için bu alan zorunludur")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hakkımda bilgisini göstermek için bu alan zorunludur")]
        [StringLength(20, ErrorMessage = "Şifre en az {1}, en fazla {2} karakter olabilir", MinimumLength = 8)]
        public string Password { get; set; }

        public int UserRole { get; set; }
    }
}
