using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Domain;



namespace OnlineLibrary.Service
{
    class BookSvcImpl : IBookSvc
    {
        DataRepository<Book> dataRep = new DataRepository<Book>();

        public void InsertBook(Book bk)
        {
            dataRep.Insert(bk);
        }

        public void RetrieveAllBooks()
        {

            List<Book> myList = dataRep.GetAll().ToList<Book>();
        }

        public void SearchBook(string BookTitle, string name)
        {
           List<Book> myList = dataRep.GetBySpecificKey(BookTitle, name).ToList<Book>();
     
        }
    }
}
