using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFwithDTO.DTOs
{
    public class StudentDTO
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public DateTime dob { get; set; }
        public double cgpa { get; set; }
    }
}