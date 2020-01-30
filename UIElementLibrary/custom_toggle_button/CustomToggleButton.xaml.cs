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

namespace UIElementLibrary.custom_toggle_button
{
    public partial class CustomToggleButton : MyUserControl, IToggleButtonInject, ICustomToggleButton
    {
        private IMyThickness leftSide;
        private IMyThickness rightSide;
        private IMyThickness marginToggleButton;
        private IMySolidColorBrush colorOff;
        private IMySolidColorBrush colorOn;
        public CustomToggleButton()
        {
            InitializeComponent();
        }

 #region CustomProperties
        public void setMySolidColorBrushColorOn(IMySolidColorBrush _mySolidColorBrush){
            this.colorOn = _mySolidColorBrush;
        }
        public void setMySolidColorBrushColorOff(IMySolidColorBrush _mySolidColorBrush){
            this.colorOff = _mySolidColorBrush;
        }

        public void setMyThicknessLeftSide(IMyThickness _myThickness){
            this.leftSide = _myThickness;
        }

        public void setMyThicknessRightSide(IMyThickness _myThickness){
            this.rightSide = _myThickness;
        }

        public void setMyThicknessMargin(IMyThickness _myThickness){
            this.marginToggleButton = _myThickness;
        }

        public CustomToggleButton init(){
            leftSide.setMyThickness(-39, 0, 0, 0);
            rightSide.setMyThickness(0, 0, -39, 0);
            colorOn.setMyConverter("#82be7d");
            
            back_rectangle.Fill = colorOff.setMyConverter("#A0A0A0");
            toggled = false;
            dot_ellipse.Margin = leftSide.getMyThickness();
            return this;
        }

        public CustomToggleButton setColorOff(String _color) {
            colorOff.setMyConverter(_color);
            return this;
        }
        public CustomToggleButton setColorOn(String _color) {
            colorOn.setMyConverter(_color);
            return this;
        }
#endregion

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
        public void setToggled(bool _toggled) {
            this.toggled = _toggled;
        }
        public bool getToggled() {
            return this.toggled;
        }

        public CustomToggleButton setSize(int _width, int _height)
        {
            this.Width = _width;
            this.Height = _height;
            return this;
        }

        public CustomToggleButton setLocation(int _x, int _y)
        {
            marginToggleButton.setMyThickness(_x, _y, 0, 0);
            this.Margin = marginToggleButton.getMyThickness();
            return this;
        }

 #endregion
    }
}
