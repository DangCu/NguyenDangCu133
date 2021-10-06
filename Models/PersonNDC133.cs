using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenDangCu133.Models
{
    public class PersonNDC133
    {
        [Key]
        [StringLength(20)]
        public int PerSonID { get; set; }
        [StringLength(50)]
        public string PerSonName { get; set; }
    }
}
