using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyBooks.Models;

namespace MyBooks.Pages.Films
{
    public class IndexModel : PageModel
    {
        private readonly MyBooks.Models.MyBooksContext _context;

        public IndexModel(MyBooks.Models.MyBooksContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; }

        public async Task OnGetAsync()
        {
            Film = await _context.Film.ToListAsync();
        }
    }
}
