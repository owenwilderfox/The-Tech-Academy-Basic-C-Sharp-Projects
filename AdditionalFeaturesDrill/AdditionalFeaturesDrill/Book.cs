using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesDrill
{
    class Book
    {
        public Book(string title) : this(title, 10)
        {
        }
        public Book(string title, int bookQuantity)
        {
            string booktitle = title;
            int BookCount = bookQuantity;
        }
        
        public string booktitle { get; set; }
        public int BookCount { get; set; }

    }
}
