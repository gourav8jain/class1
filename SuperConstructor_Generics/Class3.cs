using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperConstructor_Generics
{
    public class Class3<T>
    {
        public List<T> list2 = new List<T>();
        public void Add(T value)
        {
            list2.Add(value);
        }

    }
}
