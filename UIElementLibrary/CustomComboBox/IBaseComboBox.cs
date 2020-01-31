using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIElementLibrary.CustomComboBox
{
    public interface IBaseComboBox
    {
        BaseComboBox init();
        BaseComboBox setLabelText(String _text, String _color);
        BaseComboBox setComboBoxSize(int _width, int _height);
        BaseComboBox setLocation(int _x, int _y);
    }
}
