using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApplication.Models
{
    public class User
    {
        public User()
        {
            this.Pets = new HashSet<Pet>();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
    }
}
