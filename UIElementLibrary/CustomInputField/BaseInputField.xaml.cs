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

namespace UIElementLibrary.CustomInputField
{
    /// <summary>
    /// Interaction logic for BaseInputField.xaml
    /// </summary>
    public partial class BaseInputField : MyUserControl
    {
        public BaseInputField(){
            InitializeComponent();
            this.Width = itemName_lbl.Width + itemInput_txt.Width + 10;
        }

        public BaseInputField setLabelText(String _text, String _color){
            itemName_lbl.Content = _text;
            itemName_lbl.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString(_color);
            return this;
        }

        public BaseInputField setTextBoxWidth(int _width)
        {
            itemInput_txt.Width = _width;
            return this;
        }
    
    }
}
