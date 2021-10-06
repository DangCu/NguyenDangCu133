using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenDangCu133.Models
{
    public class NDC0133
    {
        [Key]
        [StringLength(20)]
        public int NDCid { get; set; }
        [StringLength(50)]
        public int NDCname { get; set; }
        
        public int NDCGender { get; set; }
    }
}
