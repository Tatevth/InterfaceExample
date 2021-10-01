using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IDataProvider
    {
        string GetData();
    }
    interface IDataProcessor
    {
        void ProccessData(IDataProvider dataProvider);

    }
}
