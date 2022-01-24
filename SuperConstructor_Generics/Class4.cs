using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperConstructor_Generics
{
    public class Class4<X, Y>
    {
        public Dictionary<X, Y> Dictionary = new Dictionary<X, Y>();
        public void Add(X key, Y value)
        {
            Dictionary.Add(key, value);
        }

    }
}
