using System;
using System.Collections.Generic;
using System.Text;

namespace Equals_HasCode.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public Client()
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
