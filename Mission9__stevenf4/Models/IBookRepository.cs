﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9__stevenf4.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
