using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    struct Worker
    {
       string name;
       string post;
       DateTime workStart;
       public DateTime WorkStart
        {
            get { return workStart; }
        }
       public string Name
        {
            get { return name; }
        }
        public string Post
        {
            get { return post; }
        }
       public Worker (string name, string post, DateTime time)
        {
            this.name = name;
            this.post = post;
            this.workStart = time;
            
            

        }

    }
}
