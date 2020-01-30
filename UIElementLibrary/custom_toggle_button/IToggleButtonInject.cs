using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIElementLibrary.BaseComponent;

namespace UIElementLibrary.custom_toggle_button
{
    public interface IToggleButtonInject
    {
        void setMySolidColorBrushColorOn(IMySolidColorBrush _mySolidColorBrush);
        void setMySolidColorBrushColorOff(IMySolidColorBrush _mySolidColorBrush); 
        void setMyThicknessLeftSide(IMyThickness _myThickness);
        void setMyThicknessRightSide(IMyThickness _myThickness);
        void setMyThicknessMargin(IMyThickness _myThickness);
    }
}
