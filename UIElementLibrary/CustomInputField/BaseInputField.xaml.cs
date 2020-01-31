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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UIElementLibrary.BaseComponent;
using UIElementLibrary.MyEnum;

namespace UIElementLibrary.CustomInputField
{
    public partial class BaseInputField : MyUserControl, IBaseInputField, IBaseInputFieldInject
    {
        IMySolidColorBrush mySolidColorBrush;
        IMyThickness myThickness;
        IMyVerticalAlignment myVerticalAlignment;
        IMyHorizontalAlignment myHorizontalAlignment;

        public BaseInputField(){
            InitializeComponent();
        }

        public BaseInputField init() {
            this.Width = itemName_lbl.Width + itemInput_txt.Width + 10;
            itemInput_txt.VerticalContentAlignment = myVerticalAlignment.Center();
            this.HorizontalAlignment = myHorizontalAlignment.setLeft();
            this.VerticalAlignment = myVerticalAlignment.Top();
            return this;
        }

        public BaseInputField setLabelText(String _text, String _color){
            itemName_lbl.Content = _text;
            itemName_lbl.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public BaseInputField setLocation(int _x, int _y) {
            myThickness.setMyThickness(_x, _y, 0, 0);
            this.Margin = myThickness.getMyThickness();
            return this;
        }

        public BaseInputField setTextBoxSize(int _width, int _height){
            itemInput_txt.Width = _width;
            itemInput_txt.Height = _height;
            this.Width = itemName_lbl.Width + itemInput_txt.Width + 10;
            return this;
        }

        public BaseInputField addTextBoxEventHandler(TextCompositionEventHandler _eventHandler){
            itemInput_txt.PreviewTextInput += _eventHandler;
            return this;
        }

        public void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush) {
            this.mySolidColorBrush = _mySolidColorBrush;
        }

        public void setMyThickness(IMyThickness _myThickness) {
            this.myThickness = _myThickness;
        }

        public void setMyVerticalAlignment(IMyVerticalAlignment _myVerticalAlignment) {
            this.myVerticalAlignment = _myVerticalAlignment;
        }

        public void setMyHorizontalAlignment(IMyHorizontalAlignment _myHorizontalAlignment) {
            this.myHorizontalAlignment = _myHorizontalAlignment;
        }
    }
}
