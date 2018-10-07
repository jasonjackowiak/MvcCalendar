using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCalendar.Models;

    public class memoryContext : DbContext
    {
        public memoryContext (DbContextOptions<memoryContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCalendar.Models.Event> Event { get; set; }
    }
