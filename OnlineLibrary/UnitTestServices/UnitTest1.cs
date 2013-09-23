using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineLibrary;
using System.Linq;
using System.Collections.Generic;
using OnlineLibrary.Domain;
using OnlineLibrary.Service;

namespace UnitTestServices
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactoryToInsertIntoMemberRepo()
        {
            Member memb = new Member();
            memb.FirstName = "Mary";
            memb.LastName = "Davis";
            memb.Username = "user1";
            memb.Password = "Win123";

            var memberRepo = OnlineLibrary.Service.Factory.Creates("Member");
            memberRepo.Insert(memb);
        }

        [TestMethod]
        public void TestFactoryToInsertIntoBookRepo()
        {
            Book bb = new Book();
            bb.BookTitle = "The lord of the rings";
            bb.Author = "Unknown";
            bb.BookDownload = "yes";

            var bookRepo = OnlineLibrary.Service.Factory.Creates("Book");
            bookRepo.Insert(bb);
        }

        [TestMethod]
        public void TestFactoryToInsertIntoDVDRepo()
        {
            DVD dvd = new DVD();
            dvd.DvdTitle = "Spiderman";
            dvd.DvdRating = "PG";

            var DVDRepo = OnlineLibrary.Service.Factory.Creates("DVD");
            DVDRepo.Insert(dvd);
        }

        [TestMethod]
        public void TestFactoryToDeleteFromMemberRepo()
        {
            Member memb = new Member();
            memb.FirstName = "Mary";
            memb.LastName = "Davis";
            memb.Username = "user1";
            memb.Password = "Win123";

            var memberRepo = OnlineLibrary.Service.Factory.Creates("Member");
            memberRepo.Delete(memb);
        }

        [TestMethod]
        public void TestFactoryToDeleteFromBookRepo()
        {
            Book bb = new Book();
            bb.BookTitle = "The lord of the rings";
            bb.Author = "Unknown";
            bb.BookDownload = "yes";

            var bookRepo = OnlineLibrary.Service.Factory.Creates("Book");
            bookRepo.Delete(bb);
        }

        [TestMethod]
        public void TestFactoryToDeleteFromDVDRepo()
        {
            DVD dvd = new DVD();
            dvd.DvdTitle = "Spiderman";
            dvd.DvdRating = "PG";

            var DVDRepo = OnlineLibrary.Service.Factory.Creates("DVD");
            DVDRepo.Delete(dvd);
        }
    }
}
