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

namespace UIElementLibrary.CustomComboBox
{
    public partial class BaseComboBox : MyUserControl, IBaseComboBox
    {
        public BaseComboBox()
        {
            InitializeComponent();
        }

        public BaseComboBox init()
        {
            return this;
        }

        public BaseComboBox setComboBoxSize(int _width, int _height)
        {
            return this;
        }

        public BaseComboBox setLabelText(string _text, string _color)
        {
            return this;
        }

        public BaseComboBox setLocation(int _x, int _y)
        {
            return this;
        }
    }
}
