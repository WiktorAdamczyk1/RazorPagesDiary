using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Diary.Models;

namespace Diary.Data
{
    public class DiaryContext : DbContext
    {
        public DiaryContext (DbContextOptions<DiaryContext> options)
            : base(options)
        {
        }

        public DbSet<Diary.Models.Entry> Entry { get; set; }
    }
}
