using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UIElementLibrary.BaseComponent;
using UIElementLibrary.CustomMessageBox;

namespace UIElementLibrary.CutomMessageBox
{
    public partial class MessageBoxTwoButton : MyWindow
    { 
        public MessageBoxTwoButton(){
            InitializeComponent();
        }

        public MessageBoxTwoButton setBodyMessage(string _bodyMessage, String _color){
            bodyMessage_tb.Text = _bodyMessage;
            bodyMessage_tb.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString(_color);
            return this;
        }

        public MessageBoxTwoButton setTitle(String _title, String _color){
            title_tb.Text = _title;
            title_tb.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString(_color);
            return this;
        }

        public MessageBoxTwoButton setBorderColor(String _color){
            headerBorder_brd.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFromString(_color);
            return this;
        }

        public MessageBoxTwoButton setIcon(PackIconKind _icon, String _color){
            icon.Kind = _icon;
            icon.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString(_color);
            return this;
        }

        public MessageBoxTwoButton addButton1EventHandler(RoutedEventHandler eventHandler){
            footerButton1_btn.Click += eventHandler;
            return this;
        }
        public MessageBoxTwoButton addButton2EventHandler(RoutedEventHandler eventHandler){
            footerButton2_btn.Click += eventHandler;
            return this;
        }
        public MessageBoxTwoButton setButton1Property(String _text, String _foreground, String _background){
            footerButton1_btn.Content = _text;
            footerButton1_btn.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString(_foreground);
            footerButton1_btn.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(_background);
            return this;
        }

        public MessageBoxTwoButton setButton2Property(String _text, String _foreground, String _background){
            footerButton2_btn.Content = _text;
            footerButton2_btn.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString(_foreground);
            footerButton2_btn.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(_background);
            return this;
        }

        public void showMessageBox(){
            ShowDialog();
        }

        public void closeMessageBox(){
            this.Close();
        }
    }
}
