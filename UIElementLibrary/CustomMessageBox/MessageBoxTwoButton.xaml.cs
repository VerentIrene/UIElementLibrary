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
        MySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public MessageBoxTwoButton(){
            InitializeComponent();
        }

        public MessageBoxTwoButton setBodyMessage(string _bodyMessage, String _color){
            bodyMessage_tb.Text = _bodyMessage;
            bodyMessage_tb.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public MessageBoxTwoButton setTitle(String _title, String _color){
            title_tb.Text = _title;
            title_tb.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public MessageBoxTwoButton setBorderColor(String _color){
            headerBorder_brd.BorderBrush = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public MessageBoxTwoButton setIcon(PackIconKind _icon, String _color){
            icon.Kind = _icon;
            icon.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public MessageBoxTwoButton addButton1EventHandler(RoutedEventHandler _eventHandler){
            footerButton1_btn.Click += _eventHandler;
            return this;
        }
        public MessageBoxTwoButton addButton2EventHandler(RoutedEventHandler _eventHandler){
            footerButton2_btn.Click += _eventHandler;
            return this;
        }
        public MessageBoxTwoButton setButton1Property(String _text, String _foreground, String _background){
            footerButton1_btn.Content = _text;
            footerButton1_btn.Foreground = mySolidColorBrush.setMyConverter(_foreground);
            footerButton1_btn.Background = mySolidColorBrush.setMyConverter(_background);
            return this;
        }

        public MessageBoxTwoButton setButton2Property(String _text, String _foreground, String _background){
            footerButton2_btn.Content = _text;
            footerButton2_btn.Foreground = mySolidColorBrush.setMyConverter(_foreground);
            footerButton2_btn.Background = mySolidColorBrush.setMyConverter(_foreground);
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