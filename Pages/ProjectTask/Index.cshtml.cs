using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using REIDAccess.Data;
using REIDAccess.Models;

namespace REIDAccess.Pages.ProjectTask
{
    public class IndexModel : PageModel
    {
        private readonly REIDAccess.Data.REIDAccessContext _context;

        public IndexModel(REIDAccess.Data.REIDAccessContext context)
        {
            _context = context;
        }

        public IList<ProjectTaskModel> ProjectTask { get;set; }

        public async Task OnGetAsync()
        {
            ProjectTask = await _context.ProjectTask.ToListAsync();
        }
    }
}
