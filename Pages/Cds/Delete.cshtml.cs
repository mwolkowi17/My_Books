using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyBooks.Models;

namespace MyBooks.Pages.Cds
{
    public class DeleteModel : PageModel
    {
        private readonly MyBooks.Models.MyBooksContext _context;

        public DeleteModel(MyBooks.Models.MyBooksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cd Cd { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cd = await _context.Cd.FirstOrDefaultAsync(m => m.ID == id);

            if (Cd == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cd = await _context.Cd.FindAsync(id);

            if (Cd != null)
            {
                _context.Cd.Remove(Cd);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
