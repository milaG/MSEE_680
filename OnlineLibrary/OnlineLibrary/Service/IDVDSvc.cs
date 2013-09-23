using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Domain;

namespace OnlineLibrary.Service
{
    interface IDVDSvc
    {
        void InsertDVD(DVD dvd);
        void RetrieveAllDVDs();
        void SearchDVD(string DvdTitle, string name);
    }
}
