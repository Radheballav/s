using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raaj.Application.Models
{
    public class Student
    {
        public int  Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Contactnumner { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }

    }
}