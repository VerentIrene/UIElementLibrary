using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UIElementLibrary.BaseComponent
{
    public class MyThickness : IMyThickness
    {
        private Thickness thickness;

        public MyThickness() { }

        public void setMyThickness(double _left, double _top, double _right, double _bottom)
        {
            this.thickness = new Thickness(_left, _top, _right, _bottom);
        }

        public Thickness getMyThickness()
        {
            return this.thickness;
        }
    }
}
