using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raaj.Application.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool Status { get; set; }

    }
}