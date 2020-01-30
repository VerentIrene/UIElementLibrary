using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace UIElementLibrary.BaseComponent
{
    public interface IMyDoubleAnimation
    {
        void setMyDoubleAnimation(double _toValue, IMyDuration _myDuration);

        DoubleAnimation getDoubleAnimation();

    }
}
