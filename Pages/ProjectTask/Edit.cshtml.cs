using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using REIDAccess.Data;
using REIDAccess.Models;

namespace REIDAccess.Pages.ProjectTask
{
    public class EditModel : PageModel
    {
        private readonly REIDAccess.Data.REIDAccessContext _context;

        public EditModel(REIDAccess.Data.REIDAccessContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProjectTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectTaskExists(ProjectTask.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProjectTaskExists(int id)
        {
            return _context.ProjectTask.Any(e => e.Id == id);
        }
    }
}
