using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineLibrary;

namespace DomainTest
{
    [TestClass]
    public class UnitTestMember
    {
        [TestMethod]
       public void SaveNewContactToRepository()
        {
            //entering data to be added to the database
            Member con = new Member();
            LibraryDb db = new LibraryDb();
            con.FirsNname = "Susan";
            con.LastName = "Smith";
            con.PhoneNumber = "720-456-1234";
            con.Username = "testUsername";
            con.Password = "testPassword";
            db.Contacts.AddObject(con);
            // saving the data to the database
            db.SaveChanges();

            // Check if the record retreived from the database matches the one i just added
            Contact savedContact = (from d in db.Contacts where d.id == con.id select d).Single();

            Assert.AreEqual(savedContact.FirstName, con.FirstName);
            Assert.AreEqual(savedContact.LastName, con.LastName);
            Assert.AreEqual(savedContact.PhoneNumber, con.PhoneNumber);
            Assert.AreEqual(savedContact.Username, con.Username);
            Assert.AreEqual(savedContact.Password, con.Password);

            // delete the test records from table Member from the database
            db.Contacts.DeleteObject(con);

        }
        /// Test Method to Connect to the repository and see if there are any records.
        /// This should fail if you have an empty table

        [TestMethod]
        public void ContactsRepositoryContainsData()
        {
            // arrange 
            // note connection string is in app.config
            ContactsDb db = new ContactsDb();

            // act -- go get the first record
            Contact savedContact = (from d in db.Contacts where d.id == 1 select d).Single();

            // assert
            Assert.AreEqual(savedContact.id, 1);

        }
    }
 }

