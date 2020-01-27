using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace UIElementLibrary.BaseComponent
{
    class MyDoubleAnimation
    {
        private DoubleAnimation doubleAnimation;

        public MyDoubleAnimation()
        {
        }

        public void setMyDoubleAnimation(double _toValue, MyDuration _myDuration)
        {
            this.doubleAnimation = new DoubleAnimation(_toValue, _myDuration.getMyDuration());
        }

        public  DoubleAnimation getDoubleAnimation()
        {
            return this.doubleAnimation;
        }
    }
}
