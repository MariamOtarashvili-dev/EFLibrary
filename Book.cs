using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFLibrary
{
    internal class Book 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public Library Library { get; set; }
        public BookDetails BookDetails { get; set; }
    }
}
