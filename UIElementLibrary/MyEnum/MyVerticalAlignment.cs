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

        public VerticalAlignment setTop() {
            return VerticalAlignment.Top;
        }

        public VerticalAlignment setCenter() {
            return VerticalAlignment.Center;
        }

        public VerticalAlignment setBottom() {
            return VerticalAlignment.Bottom;
        }

        public VerticalAlignment setStretch() {
            return VerticalAlignment.Stretch;
        }
    }
}
