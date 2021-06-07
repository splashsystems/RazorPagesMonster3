using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonster3.Data;
using RazorPagesMonster3.Models;

namespace RazorPagesMonster3.Pages.Monsters
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMonster3.Data.RazorPagesMonster3Context _context;

        public IndexModel(RazorPagesMonster3.Data.RazorPagesMonster3Context context)
        {
            _context = context;
        }

        public IList<Monster> Monster { get;set; }

        public async Task OnGetAsync()
        {
            Monster = await _context.Monster.ToListAsync();
        }
    }
}
