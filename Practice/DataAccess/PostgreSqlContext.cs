using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;


namespace Practice.DataAccess
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options) { }
        public DbSet<Groups> groups { get; set; }
        public DbSet<Students> students { get; set; }
    }
}
