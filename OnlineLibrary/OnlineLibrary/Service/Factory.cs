using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineLibrary.Domain;

namespace OnlineLibrary.Service
{
    public class Factory
    {
        public static IDataRepository Creates(string repoType)
        {
            IDataRepository dataRepo;
            switch (repoType)
            {
                case "Member":
                    dataRepo = new DataRepository<Member>();
                    break;
                case "Book":
                    dataRepo = new DataRepository<Book>();
                    break;
                case "DVD":
                    dataRepo = new DataRepository<DVD>();
                    break;
                default:
                    dataRepo = null;
                    throw new System.ArgumentException("Invalid Input. Not supported type." + repoType);
            }
            return dataRepo;
        }

    }
}
