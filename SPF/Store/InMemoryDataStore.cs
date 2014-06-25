using SPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPF.Store
{
    public class InMemoryDataStore : IDataStore
    {
        public bool CreateDataStore()
        {
            throw new NotImplementedException();
        }

        public bool CreateDataStore(string schemaFilePath)
        {
            throw new NotImplementedException();
        }

        public bool CreateDataStore(Common.StoreType type)
        {
            throw new NotImplementedException();
        }
    }
}
