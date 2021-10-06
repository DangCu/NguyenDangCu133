using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenDangCu133.Models;

namespace NDC0133.Data
{
    public class NDC0133Context : DbContext
    {
        public NDC0133Context (DbContextOptions<NDC0133Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenDangCu133.Models.NDC0133> NDC0133 { get; set; }
    }
}
