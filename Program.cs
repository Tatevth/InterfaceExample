using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{  
    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProccessData(new APIDataProvider());
            dataProcessor.ProccessData(new FileDataProvider());
            dataProcessor.ProccessData(new DbDataProvider());

            Console.ReadKey();
        }   
    }
}
