using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperConstructor_Generics
{
    public class Class2 : Class1
    {
        public Class2(string name) : base(name)
        {
            Console.WriteLine("Class2 - Derived Class" + name);
        }
    }
}
