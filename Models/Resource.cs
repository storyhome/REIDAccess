using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REIDAccess.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cell { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public ProjectTask Task { get; set; }
    }
}
