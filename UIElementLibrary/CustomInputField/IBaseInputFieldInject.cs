using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIElementLibrary.BaseComponent;
using UIElementLibrary.MyEnum;

namespace UIElementLibrary.CustomInputField
{
    public interface IBaseInputFieldInject
    {
        void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush);
        void setMyThickness(IMyThickness _myThickness);
        void setMyVerticalAlignment(IMyVerticalAlignment _myVerticalAlignment);
        void setMyHorizontalAlignment(IMyHorizontalAlignment _myHorizontalAlignment);
    }
}
