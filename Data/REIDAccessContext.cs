using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using REIDAccess.Models;

namespace REIDAccess.Data
{
    public class REIDAccessContext : DbContext
    {
        public REIDAccessContext (DbContextOptions<REIDAccessContext> options)
            : base(options)
        {
        }

        public DbSet<REIDAccess.Models.ProjectModel> Project { get; set; }
        public DbSet<REIDAccess.Models.ProjectTaskModel> ProjectTask { get; set; }
        public DbSet<REIDAccess.Models.Resource> Resource { get; set; }
    }
}
