﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consumebookapi.Models
{
    public class BookInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }
    }
}
