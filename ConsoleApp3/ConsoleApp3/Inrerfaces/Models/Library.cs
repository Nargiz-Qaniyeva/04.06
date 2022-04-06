using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Inrerfaces.Models
{
    class Library : IEntity
    {
        public int Id { get; }
        public int BookLimit { get; set; }
        private List<Book> _books;

    }
}
