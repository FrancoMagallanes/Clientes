using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TrabajoMax.Models;

namespace TrabajoMax.Repository
{
    public class TabajoMaxContext : DbContext
    {
        public TabajoMaxContext(DbContextOptions<TabajoMaxContext> options)
          : base(options)
        {
        }


        public DbSet<Cliente> Cliente { get; set; }

    }
}
