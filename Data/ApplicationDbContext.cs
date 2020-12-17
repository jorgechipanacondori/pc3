using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Practica3.Models;

namespace Practica3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {/*
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }*/
          public DbSet<Registrar> Registrar { get; set; }

        public ApplicationDbContext(DbContextOptions dco) : base(dco) {

        }
    }
}