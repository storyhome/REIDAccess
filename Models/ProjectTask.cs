using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REIDAccess.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Needed { get; set; }
        public Project Project { get; set; }
        public IEnumerable<Resource> Resources { get; set; }
    }
}
