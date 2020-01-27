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

namespace UIElement
{
    /// <summary>
    /// Interaction logic for CustomToggleButton.xaml
    /// </summary>
    public partial class CustomToggleButton : MyUserControl
    {
        MyThickness leftSide = new MyThickness();
        MyThickness rightSide = new MyThickness();
        MySolidColorBrush colorOff = new MySolidColorBrush();
        MySolidColorBrush colorOn = new MySolidColorBrush();

        public CustomToggleButton()
        {
            leftSide.setMyThickness(-39, 0, 0, 0);
            rightSide.setMyThickness(0, 0, -39, 0);
            colorOff.setMySolidColorBrush(Color.FromRgb(160, 160, 160));
            colorOn.setMySolidColorBrush(Color.FromRgb(130, 190, 125));
            InitializeComponent();
            back_rectangle.Fill = colorOff.getMySolidColorBrush();
            toggled = false;
            dot_ellipse.Margin = leftSide.getMyThickness();
        }

#region EventHandler
        private void OnMouseLeftButtonDownDot_ellipse(object sender, MouseButtonEventArgs e)
        {
            if (!toggled)
            {
                back_rectangle.Fill = colorOn.getMySolidColorBrush();
                toggled = true;
                dot_ellipse.Margin = rightSide.getMyThickness();
            }
            else
            {
                back_rectangle.Fill = colorOff.getMySolidColorBrush();
                toggled = false;
                dot_ellipse.Margin = leftSide.getMyThickness();
            }
        }

        private void OnMouseLeftButtonDownBack_rectangle(object sender, MouseButtonEventArgs e)
        {
            if (!toggled)
            {
                back_rectangle.Fill = colorOn.getMySolidColorBrush();
                toggled = true;
                dot_ellipse.Margin = rightSide.getMyThickness();
            }
            else
            {
                back_rectangle.Fill = colorOff.getMySolidColorBrush();
                toggled = false;
                dot_ellipse.Margin = leftSide.getMyThickness();
            }
        }
#endregion

#region setter-getter

        private bool toggled = false;
        public void setToggled(bool _toggled)
        {
            this.toggled = _toggled;
        }
        public bool getToggled()
        {
            return this.toggled;
        }

#endregion
    }
}
