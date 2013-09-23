using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Domain;

namespace OnlineLibrary.Service
{
    class MemberSvcImpl : IMemberSvc
    {
        DataRepository<Member> dataRep = new DataRepository<Member>();

        public void InsertMember(Member memb)
        {
           dataRep.Insert(memb);
        }

        public void RetrieveAllMembers()
        {

            List<Member> myList = dataRep.GetAll().ToList<Member>();
        }

        public void SearchMember(string FirstName, string name)
        {
            List<Member> myList = dataRep.GetBySpecificKey(FirstName, name).ToList<Member>();

        }
    }
}
