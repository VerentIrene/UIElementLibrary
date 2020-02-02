using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace UIElementLibrary.BaseComponent
{
    public class MyList<T> : List<T>
    {
        public MyList() { }

        public MyList(int capacity) : base(capacity) { }

        public MyList(IEnumerable<T> collection) : base(collection) { }
    }
}
