using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Domain;

namespace OnlineLibrary.Service
{
    interface IMemberSvc
    {
        void InsertMember(Member memb);
        void RetrieveAllMembers();
        void SearchMember(string FirstName, string name);
    }
}