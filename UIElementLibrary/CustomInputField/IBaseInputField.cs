using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UIElementLibrary.CustomInputField
{
    public interface IBaseInputField
    {
        BaseInputField init();
        BaseInputField setLabelText(String _text, String _color);
        BaseInputField setTextBoxSize(int _width, int _height);
        BaseInputField setLocation(int _x, int _y);
        BaseInputField addTextBoxEventHandler(TextCompositionEventHandler _eventHandler);
    }
}
