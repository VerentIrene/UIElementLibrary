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

namespace UIElementLibrary.CustomComboBox
{
    public partial class BaseComboBox : MyUserControl, IBaseComboBox, IBaseComboBoxInject
    {
        IMySolidColorBrush mySolidColorBrush;
        IMyThickness myThickness;
        IMyVerticalAlignment myVerticalAlignment;
        IMyHorizontalAlignment myHorizontalAlignment;

        public BaseComboBox() {
            InitializeComponent();
        }

        public BaseComboBox init() {
            this.Width = itemName_lbl.Width + itemList_cbo.Width + 10;
            this.HorizontalAlignment = myHorizontalAlignment.setLeft();
            this.VerticalAlignment = myVerticalAlignment.setTop();
            return this;
        }

        public BaseComboBox setComboBoxSize(int _width, int _height) {
            itemList_cbo.Width = _width;
            itemList_cbo.Height = _height;
            return this;
        }

        public BaseComboBox setLabelText(string _text, string _color) {
            itemName_lbl.Content = _text;
            itemName_lbl.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public BaseComboBox setLocation(int _x, int _y) {
            myThickness.setMyThickness(_x, _y, 0, 0);
            this.Margin = myThickness.getMyThickness();
            return this;
        }

        public BaseComboBox addItem(String _item) {
            itemList_cbo.Items.Add(_item);
            itemList_cbo.SelectedIndex = 0;
            return this;
        }

        public BaseComboBox addItemList(MyList<string> _listOfItem) {
            itemList_cbo.ItemsSource = _listOfItem;
            itemList_cbo.SelectedIndex = 0;
            return this;
        }

        public void setMyHorizontalAlignment(IMyHorizontalAlignment _myHorizontalAlignment) {
            this.myHorizontalAlignment = _myHorizontalAlignment;
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
    }
}
