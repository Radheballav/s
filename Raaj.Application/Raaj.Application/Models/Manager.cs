using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raaj.Application.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Department { get; set; }
        public double Salary { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

    }
}