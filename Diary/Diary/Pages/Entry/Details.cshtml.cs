using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Diary.Data;
using Diary.Models;

namespace Diary.Pages.Entry
{
    public class DetailsModel : PageModel
    {
        private readonly Diary.Data.DiaryContext _context;

        public DetailsModel(Diary.Data.DiaryContext context)
        {
            _context = context;
        }

        public Models.Entry Entry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Entry = await _context.Entry.FirstOrDefaultAsync(m => m.ID == id);

            if (Entry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
