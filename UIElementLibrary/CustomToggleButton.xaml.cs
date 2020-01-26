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
        Thickness leftSide = new Thickness(-39, 0, 0, 0);
        Thickness rightSide = new Thickness(0, 0, -39, 0);
        SolidColorBrush colorOff = new SolidColorBrush(Color.FromRgb(160,160,160));
        SolidColorBrush colorOn = new SolidColorBrush(Color.FromRgb(130,190,125));

        public CustomToggleButton()
        {
            InitializeComponent();
            back_rectangle.Fill = colorOff;
            toggled = false;
            dot_ellipse.Margin = leftSide;
        }

#region EventHandler
        private void OnMouseLeftButtonDownDot_ellipse(object sender, MouseButtonEventArgs e)
        {
            if (!toggled)
            {
                back_rectangle.Fill = colorOn;
                toggled = true;
                dot_ellipse.Margin = rightSide;
            }
            else
            {
                back_rectangle.Fill = colorOff;
                toggled = false;
                dot_ellipse.Margin = leftSide;
            }
        }

        private void OnMouseLeftButtonDownBack_rectangle(object sender, MouseButtonEventArgs e)
        {
            if (!toggled)
            {
                back_rectangle.Fill = colorOn;
                toggled = true;
                dot_ellipse.Margin = rightSide;
            }
            else
            {
                back_rectangle.Fill = colorOff;
                toggled = false;
                dot_ellipse.Margin = leftSide;
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
