using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace UIElementLibrary.BaseComponent
{
    class MyDoubleAnimation : IMyDoubleAnimation
    {
        private DoubleAnimation doubleAnimation;

        public MyDoubleAnimation()
        {
        }

        public  DoubleAnimation getDoubleAnimation()
        {
            return this.doubleAnimation;
        }

        public void setMyDoubleAnimation(double _toValue, IMyDuration _myDuration)
        {
            this.doubleAnimation = new DoubleAnimation(_toValue, _myDuration.getMyDuration());
        }
    }
}
