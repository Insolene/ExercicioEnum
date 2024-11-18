using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnum.Entities
{
    internal class Client
    {
        public string Name { get; set; } 
        public string Email { get; set; }
        public DateTime Birday { get; set; }

        public Client() { }

        public Client(string name, string email, DateTime birday)
        {
            Name = name;
            Email = email;
            Birday = birday;
        }
        public override string ToString()
        {
            return Name
                + ", ("
                + Birday.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
