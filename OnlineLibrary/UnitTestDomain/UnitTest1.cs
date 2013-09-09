using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineLibrary;
using System.Linq; 

namespace UnitTestDomain
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddBook()
        {
            LibraryEntities Db = new LibraryEntities();

            Book bb = new Book();
            bb.BookTitle = "the hobbit";
            bb.Author = "tolkien";
            bb.BookDownload = "yes";

            Db.Books.Add(bb);
            Db.SaveChanges();
        }

        [TestMethod]
        public void TestAddDvd()
        {
            LibraryEntities Db = new LibraryEntities();

            DVD dvd = new DVD();
            dvd.DvdTitle = "Superman";
            dvd.DvdRating = "PG";

            Db.DVDs.Add(dvd);
            Db.SaveChanges();
        }

        [TestMethod]
        public void TestAddMember()
        {
            LibraryEntities Db = new LibraryEntities();

            Member memb = new Member();
            memb.FirstName = "Susan";
            memb.LastName = "Smith";
            memb.Username = "userrtest";
            memb.Password = "123";

            Db.Members.Add(memb);
            Db.SaveChanges();
        }

        [TestMethod]
        public void TestDeleteBook()
        {
            LibraryEntities Db = new LibraryEntities();

            Book deleteBook = (from del in Db.Books where del.BookTitle == "the hobbit" select del).FirstOrDefault();
            Db.Books.Remove(deleteBook);
            Db.SaveChanges();
        }

        [TestMethod]
        public void TestDeleteDVD()
        {
            LibraryEntities Db = new LibraryEntities();

            DVD deleteDVD = (from del in Db.DVDs where del.DvdTitle == "Superman" select del).FirstOrDefault();
            Db.DVDs.Remove(deleteDVD);
            Db.SaveChanges();
        }

        [TestMethod]
        public void TestDeleteMember()
        {
            LibraryEntities Db = new LibraryEntities();

            Member deleteMember = (from del in Db.Members where del.Username == "userrtest" select del).FirstOrDefault();
            Db.Members.Remove(deleteMember);
            Db.SaveChanges();
        }

    }
}
