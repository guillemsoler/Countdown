using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountdownApi.Models
{
    public class CountdownContext : DbContext
    {
        public CountdownContext(DbContextOptions<CountdownContext> options)
        : base(options)
        {
        }

        public DbSet<CountdownModel> CountdownModels { get; set; }
    }
}
