using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Domain;

namespace OnlineLibrary.Service
{
    class DVDSvcImpl : IDVDSvc
    {
       DataRepository<DVD> dataRep = new DataRepository<DVD>();

        public void InsertDVD(DVD dvd)
        {
           dataRep.Insert(dvd);
        }

        public void RetrieveAllDVDs()
        {

            List<DVD> myList = dataRep.GetAll().ToList<DVD>();
        }

        public void SearchDVD(string DvdTitle, string name)
        {
            List<DVD> myList = dataRep.GetBySpecificKey(DvdTitle, name).ToList<DVD>();

        }
    }
}
