using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APARTMENTS.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public string ApartmentDescription { get; set; }
        public int NumberOfRooms { get; set; }
        public int MonthlyPrice { get; set; }


        [JsonIgnore]
        public ICollection<Contract> contracts { get; set; }
        public Adress Adress { get; set; }
        public int UserId { get; set; }
        public User owner { get; set; }

    }
}
