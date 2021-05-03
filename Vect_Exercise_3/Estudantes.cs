using System;
using System.Collections.Generic;
using System.Text;

namespace Vect_Exercise_3
{
    class Estudantes
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Estudantes(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }

    }
}
