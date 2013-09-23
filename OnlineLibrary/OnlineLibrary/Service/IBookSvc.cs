using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Domain;

namespace OnlineLibrary.Service
{
    interface IBookSvc
    {
        void InsertBook(Book bk);
        void RetrieveAllBooks();
        void SearchBook(string BookTitle, string name);
    }
}
