using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineLibrary;
using System.Linq;
using System.Collections.Generic;
using OnlineLibrary.Domain;
using OnlineLibrary.Service;


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

        [TestMethod]
        public void InsertMemberByRepository()
        {
            var memberRepo = new DataRepository<Member>();

            Member memb = new Member();
            memb.FirstName = "mary";
            memb.LastName = "Davis";
            memb.Username = "userrtest2";
            memb.Password = "1234";

            memberRepo.Insert(memb);
        }

        [TestMethod]
        public void InsertBookByRepository()
        {
            var bookRepo = new DataRepository<Book>();

            Book bb = new Book();
            bb.BookTitle = "Great Book";
            bb.Author = "Mila";
            bb.BookDownload = "yes";

            bookRepo.Insert(bb);
        }

        [TestMethod]
        public void InsertDVDByRepository()
        {
            var DVDRepo = new DataRepository<DVD>();

            DVD dvd = new DVD();
            dvd.DvdTitle = "Ariel";
            dvd.DvdRating = "E";

            DVDRepo.Insert(dvd);
        }

        [TestMethod]
        public void RetrieveMembersUsingRepository()
        {
            var memberRepo = new DataRepository<Member>();

            List<Member> myList = memberRepo.GetAll().ToList<Member>();
            Assert.IsTrue(myList.Count > 0);
        }

        [TestMethod]
        public void RetrieveBooksUsingRepository()
        {
            var bookRepo = new DataRepository<Book>();

            List<Book> myList = bookRepo.GetAll().ToList<Book>();
            Assert.IsTrue(myList.Count > 0);
        }

        [TestMethod]
        public void RetrieveDVDsUsingRepository()
        {
            var DVDRepo = new DataRepository<DVD>();

            List<DVD> myList = DVDRepo.GetAll().ToList<DVD>();
            Assert.IsTrue(myList.Count > 0);
        }
    }
}
