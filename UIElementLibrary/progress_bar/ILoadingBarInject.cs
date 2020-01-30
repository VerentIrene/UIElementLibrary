using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIElementLibrary.BaseComponent;

namespace UIElementLibrary.progress_bar
{

    public interface ILoadingBarInject
    {
        void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush);
        void setMyDuration(IMyDuration _myDuration);
        void setMyDoubleAnimation(IMyDoubleAnimation _myDoubleAnimation);
        
    }
}
