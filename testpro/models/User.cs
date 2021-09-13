using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testpro.models
{
    public class User
    {
        public User()
        {
        }

        public User(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime DoB { get; set; }
        public string  name { get; set; }
        public int age { get; set; }
    }
}
