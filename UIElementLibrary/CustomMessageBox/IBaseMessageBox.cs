using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UIElementLibrary.CutomMessageBox;

namespace UIElementLibrary.CustomMessageBox
{
    public interface IBaseMessageBox
    {
        BaseMessageBox setTitle(string _bodyMessage, String _color);
        BaseMessageBox setBodyMessage(string _bodyMessage, String _color);
        BaseMessageBox setBorderColor(String _color);
        BaseMessageBox setIcon(PackIconKind _icon, String _color);
        BaseMessageBox addButtonEventHandler(RoutedEventHandler eventHandler);

        BaseMessageBox setButtonProperty(String _text, String _foreground, String _background);

        void showMessageBox();
        void closeMessageBox();
    }
}
