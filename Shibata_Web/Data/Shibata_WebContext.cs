using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shibata_Web.Models;

    public class Shibata_WebContext : DbContext
    {
        public Shibata_WebContext (DbContextOptions<Shibata_WebContext> options)
            : base(options)
        {
        }

        public DbSet<Shibata_Web.Models.UsuarioViewModel> UsuarioViewModel { get; set; }
    }
