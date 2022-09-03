using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorMVC_AGAX.Models
{
    public class CalculateDbContext : DbContext
    {
        public CalculateDbContext(DbContextOptions<CalculateDbContext> options) : base(options)
        {

        }
        public DbSet<CalculateModel> Numbers { get; set; }
    }
}
