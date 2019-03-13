using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class WorkerBase
    {
        private List <Worker> wokersArray = new List <Worker> ();

        public IEnumerable<Worker> WokersArray
        {
            get { return wokersArray; }
        }
        public void AddWorker(Worker worker)
        {
            wokersArray.Add(worker);
        }


        public List <Worker> GetExpeirenceWorker (int year)
        {
            DateTime timeNow = DateTime.Now;

            DateTime maxStart = timeNow.AddYears(-year);


            var result =
                 from worker in wokersArray
                 where maxStart > worker.WorkStart
                 select worker;
            return result.ToList();                 
        }
        public List <Worker> OrderWokers ()
        {
            var quary =
                from worker in wokersArray
                orderby worker.Name
                select worker;
            return quary.ToList();
        }
    }
}
