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
    public class IndexModel : PageModel
    {
        private readonly Diary.Data.DiaryContext _context;

        public IndexModel(Diary.Data.DiaryContext context)
        {
            _context = context;
        }

        public IList<Models.Entry> Entry { get;set; }

        public async Task OnGetAsync()
        {
            Entry = await _context.Entry.ToListAsync();
        }
    }
}
