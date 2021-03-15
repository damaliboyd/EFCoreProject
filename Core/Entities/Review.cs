using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Review
    {
        public string Reviewer { get; set; }
        public string Text { get; set; }
        public Book Book { get; set; }
    }
}
