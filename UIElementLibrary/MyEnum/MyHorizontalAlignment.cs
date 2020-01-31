using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UIElementLibrary.MyEnum
{
    public class MyHorizontalAlignment : IMyHorizontalAlignment
    { 
        public MyHorizontalAlignment() { }

        public HorizontalAlignment setLeft() {
            return HorizontalAlignment.Left;
        }

        public HorizontalAlignment setCenter(){
            return HorizontalAlignment.Center;
        }

        public HorizontalAlignment setRight(){
            return HorizontalAlignment.Right;
        }

        public HorizontalAlignment setStretch() {
            return HorizontalAlignment.Stretch;
        }
    }
}
