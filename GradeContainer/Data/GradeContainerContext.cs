using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GradeContainer.Models;

namespace GradeContainer.Data
{
    public class GradeContainerContext : DbContext
    {
        public GradeContainerContext (DbContextOptions<GradeContainerContext> options)
            : base(options)
        {
        }

        public DbSet<GradeContainer.Models.Course> Course { get; set; } = default!;
    }
}
