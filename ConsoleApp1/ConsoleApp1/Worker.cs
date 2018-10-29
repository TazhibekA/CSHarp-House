using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Worker : IWorker
    {
      
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Worker( string lastName, string name)
        {
    
            LastName = lastName;
            Name = name;
        }
    }
}
