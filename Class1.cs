using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contuctor
{
    internal class Class1
    {
       public int id;
       public string name;
        public char sec ;
      
        public Class1()
        {

        }
        public Class1(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
       public Class1(int id, string name,char sec)
        {
            this.id = id;
            this.name = name;
            this.sec = sec;
        }

        public void detail()
        {
            Console.WriteLine("the id is {0}", id);
            Console.WriteLine("the name is {0}", name);
            Console.WriteLine("the section is {0}", sec);

        }
    }
}
