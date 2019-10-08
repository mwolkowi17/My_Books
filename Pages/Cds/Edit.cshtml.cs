using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyBooks.Models;

namespace MyBooks.Pages.Cds
{
    public class EditModel : PageModel
    {
        private readonly MyBooks.Models.MyBooksContext _context;

        public EditModel(MyBooks.Models.MyBooksContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CdExists(Cd.ID))
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

        private bool CdExists(int id)
        {
            return _context.Cd.Any(e => e.ID == id);
        }
    }
}
