using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Dtos
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int UserRole { get; set; }
        public int PhoneNumber { get; set; }

        

        public ICollection<GetApartmentDto> apartments { get; set; }
    }
}
