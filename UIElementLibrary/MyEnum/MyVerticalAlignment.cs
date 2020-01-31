using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UIElementLibrary.MyEnum
{
    public class MyVerticalAlignment : IMyVerticalAlignment
    {
        public MyVerticalAlignment() { }

        public VerticalAlignment Top() {
            return VerticalAlignment.Top;
        }

        public VerticalAlignment Center() {
            return VerticalAlignment.Center;
        }

        public VerticalAlignment Bottom() {
            return VerticalAlignment.Bottom;
        }

        public VerticalAlignment Stretch() {
            return VerticalAlignment.Stretch;
        }
    }
}
