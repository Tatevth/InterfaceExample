using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from API";
        }
    }
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from files";
        }
    }
    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from db";
        }
    }
}
