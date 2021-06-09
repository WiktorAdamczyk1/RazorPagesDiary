using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Diary.Models
{
    public class Entry
    {

        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        public string Text { get; set; }

    }
}
