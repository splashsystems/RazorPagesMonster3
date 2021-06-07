using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonster3.Models;

namespace RazorPagesMonster3.Data
{
    public class RazorPagesMonster3Context : DbContext
    {
        public RazorPagesMonster3Context (DbContextOptions<RazorPagesMonster3Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMonster3.Models.Monster> Monster { get; set; }
    }
}
