using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UIElementLibrary.BaseComponent
{
    public interface IMyThickness
    {
        void setMyThickness(double _left, double _top, double _right, double _bottom);

        Thickness getMyThickness();
    }
}
