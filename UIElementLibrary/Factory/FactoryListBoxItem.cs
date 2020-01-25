using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UIElementLibrary.BaseComponent;

namespace UIElementLibrary.Factory
{
    class FactoryListBoxItem
    {
        public static int heightBox = 30;
        public FactoryListBoxItem() { }

        public MyListBoxItem AddListBoxItem(String _textListItem)
        {
            MyListBoxItem listBoxItem = new MyListBoxItem();
            listBoxItem.Foreground = Brushes.Black;
            listBoxItem.Content = _textListItem.ToString();
            listBoxItem.Height = heightBox;
            listBoxItem.FontSize = 10;
            return listBoxItem;
        }
    }
}
