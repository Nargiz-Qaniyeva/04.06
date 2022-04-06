using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Inrerfaces.Models
{
    class Book :IEntity
    {
        public string  Name { get; set; }
        public string  AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; } = false;

        public int Id { get; }

        public void ShowInfo()
        {

        }
        public Book()
        {
            this.Name = Name;
            this.AuthorName = AuthorName;
            this.PageCount = PageCount;
        }
    }
}
