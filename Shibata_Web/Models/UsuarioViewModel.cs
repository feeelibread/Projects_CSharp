using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shibata_Web.Models
{
    public class UsuarioViewModel : IdentityViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
