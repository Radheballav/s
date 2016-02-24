using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raaj.Application.Models
{
    public class Facilitator
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string JoinDate { get; set; }
        public double Salary { get; set; }
        public bool Description { get; set; }
    }
}