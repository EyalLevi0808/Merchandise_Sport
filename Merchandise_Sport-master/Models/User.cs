using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Merchandise_Sport_master.Models
{
    public enum UserType
    {
        Client,
        Admin,
        Editor
    }
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Username need to be more then one letter")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Password need to be more then 4 letter")]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "email need to be more then 2 letter")]
        public string Email { get; set; }


        public string Address { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Favorite Team")]

        public String FavoriteTeam { get; set; }

        public UserType Type { get; set; } = UserType.Client;

    }
}
