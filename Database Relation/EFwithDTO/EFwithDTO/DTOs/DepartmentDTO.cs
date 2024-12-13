using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFwithDTO.DTOs
{
    public class DepartmentDTO
    {
        public int id { get; set; }
        [Required]
        [StringLength(10)]
        public string name { get; set; }
    }
}