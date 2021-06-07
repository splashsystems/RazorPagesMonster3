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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMonster3.Data.RazorPagesMonster3Context _context;

        public DetailsModel(RazorPagesMonster3.Data.RazorPagesMonster3Context context)
        {
            _context = context;
        }

        public Monster Monster { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monster = await _context.Monster.FirstOrDefaultAsync(m => m.ID == id);

            if (Monster == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
