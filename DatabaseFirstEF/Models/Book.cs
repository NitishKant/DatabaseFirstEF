using System;
using System.Collections.Generic;

namespace DatabaseFirstEF.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
