using SPF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPF.Interfaces
{
    public interface IDataStore
    {
        Boolean CreateDataStore();
        Boolean CreateDataStore(String schemaFilePath);
        Boolean CreateDataStore(StoreType type);
    }
}
