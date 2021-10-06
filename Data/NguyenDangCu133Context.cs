using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenDangCu133.Models;

namespace NguyenDangCu133.Data
{
    public class NguyenDangCu133Context : DbContext
    {
        public NguyenDangCu133Context (DbContextOptions<NguyenDangCu133Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenDangCu133.Models.PersonNDC133> PersonNDC133 { get; set; }
    }
}
