using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Author
    {
        public string FirstName;
        public string LastName;
        public ICollection<Book> Books;
}
