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
    public class DetailsModel : PageModel
    {
        private readonly REIDAccess.Data.REIDAccessContext _context;

        public DetailsModel(REIDAccess.Data.REIDAccessContext context)
        {
            _context = context;
        }

        public ProjectTaskModel ProjectTask { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProjectTask = await _context.ProjectTask.FirstOrDefaultAsync(m => m.Id == id);

            if (ProjectTask == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
