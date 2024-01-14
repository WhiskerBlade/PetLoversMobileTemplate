using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.Models
{
    public class LoggedInUser
    {
        public static LoggedInUser Current { get; private set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string City { get; set; }

        public string? State { get; set; } = null;

        public string Country { get; set; }


        public ImageSource Avatar { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string ConcatCityStateCountry
        {
            get {
                List<string> blocks = new List<string>();
                blocks.Add(City);
                if(State != null)
                {
                    blocks.Add(State);
                }
                blocks.Add(Country);
                return string.Join(",", [.. blocks]);
            }
        }

        public LoggedInUser()
        {
            Current = this;
        }
    }
}
