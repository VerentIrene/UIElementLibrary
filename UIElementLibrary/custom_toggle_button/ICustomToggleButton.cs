using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIElementLibrary.custom_toggle_button
{
    public interface ICustomToggleButton
    {
        CustomToggleButton setColorOff(String _color);
        CustomToggleButton setColorOn(String _color);
        CustomToggleButton setSize(int _width, int _height);
        CustomToggleButton setLocation(int _x, int _y);
        CustomToggleButton init();
        void setToggled(bool _toggled);
        bool getToggled();


    }
}
