using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rad_Alexandra_Laborator8.Data;
using Rad_Alexandra_Laborator8.Models;

namespace Rad_Alexandra_Laborator8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Rad_Alexandra_Laborator8.Data.Rad_Alexandra_Laborator8Context _context;

        public IndexModel(Rad_Alexandra_Laborator8.Data.Rad_Alexandra_Laborator8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
