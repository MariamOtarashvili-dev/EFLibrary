using System;
using System.Collections.Generic;
using System.Text;

namespace EFLibrary
{
    internal class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Address { get; set; }

       public List<Book> Books { get; set; }
    }
}
