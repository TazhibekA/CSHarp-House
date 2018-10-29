using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Team
    {
       
        public List<Worker> workers { get; set; }

        public Team(List<Worker> workers)
        {
          
            this.workers = workers;
        }

        public void AddWorker (Worker worker){
            workers.Add(worker);
        }

        
    }
}
