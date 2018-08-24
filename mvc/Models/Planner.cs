using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvc.Models
{
    public class Planner
    {
        public int id { get; set; }
        public string content { get; set; }
    }
}
