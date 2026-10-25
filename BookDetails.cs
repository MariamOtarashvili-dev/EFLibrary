using System;
using System.Collections.Generic;
using System.Text;

namespace EFLibrary
{
    internal class BookDetails
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public int PageCount { get; set; }
        public int PublishedYear { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}


