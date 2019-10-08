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
    public class DetailsModel : PageModel
    {
        private readonly MyBooks.Models.MyBooksContext _context;

        public DetailsModel(MyBooks.Models.MyBooksContext context)
        {
            _context = context;
        }

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
    }
}
