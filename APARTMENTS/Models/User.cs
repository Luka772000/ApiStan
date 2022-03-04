using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace APARTMENTS.Models
{
    public class User: IdentityUser<int>
    {
        public DateTime DateOfBirth { get; set; }
        

        public ICollection<Contract> contracts { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public Apartment apartment { get; set; }
        
    }
}
 