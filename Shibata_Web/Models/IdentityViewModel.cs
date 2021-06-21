using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shibata_Web.Models
{
    public class IdentityViewModel
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }

        public IdentityViewModel()
        {
            Id = Guid.NewGuid();

        }
    }
}
