using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restFullApi.model.Context
{
    public class MySQLContext:DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options):base(options) { }

        public DbSet<Persons> Persons { get; set; }

        public DbSet<Books> Books { get; set; }

    }
}
