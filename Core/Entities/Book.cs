using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
