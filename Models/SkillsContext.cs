using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Developer_Challenge___Open_Web_Technology.Models
{
    public class SkillsContext : DbContext
    {
        public SkillsContext(DbContextOptions<SkillsContext> options)
            : base(options)
        {
        }

        public DbSet<Skills> Skills { get; set; }

    }
}
