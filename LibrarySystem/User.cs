﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public abstract class User
    {
        public  string Name { get; set; }
        public void DisplyBooks(Library library)
        {
            library.DisplyBook();
        }
    }
}
