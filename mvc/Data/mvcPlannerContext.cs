using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvc.Models
{
    public class mvcPlannerContext : DbContext
    {
        public mvcPlannerContext (DbContextOptions<mvcPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<mvc.Models.Planner> Planner { get; set; }
    }
}
