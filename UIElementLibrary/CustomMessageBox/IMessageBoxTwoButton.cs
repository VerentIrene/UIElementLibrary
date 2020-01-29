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
    public interface IMessageBoxTwoButton
    {

        MessageBoxTwoButton setBodyMessage(string _bodyMessage, String _color);

        MessageBoxTwoButton setTitle(String _title, String _color);

        MessageBoxTwoButton setBorderColor(String _color);

        MessageBoxTwoButton setIcon(PackIconKind _icon, String _color);

        MessageBoxTwoButton addLeftButtonEventHandler(RoutedEventHandler _eventHandler);
        MessageBoxTwoButton addRightButtonEventHandler(RoutedEventHandler _eventHandler);
        MessageBoxTwoButton setLeftButtonProperty(String _text, String _foreground, String _background);

        MessageBoxTwoButton setRightButtonProperty(String _text, String _foreground, String _background);

        void showMessageBox();
        void closeMessageBox();
    }
}
