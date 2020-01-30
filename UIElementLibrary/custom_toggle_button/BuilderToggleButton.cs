using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIElementLibrary.BaseComponent;

namespace UIElementLibrary.custom_toggle_button
{
    public class BuilderToggleButton
    {
        private IMySolidColorBrush colorOn = new MySolidColorBrush();
        private IMySolidColorBrush colorOff = new MySolidColorBrush();
        private IMyThickness rightSide = new MyThickness();
        private IMyThickness leftSide= new MyThickness();
        private IMyThickness margin= new MyThickness();

        public BuilderToggleButton() {

        }

        public ICustomToggleButton buildCustomToggleButton() {

            ICustomToggleButton myToggleButton = new CustomToggleButton();
            IToggleButtonInject toggleButtonInject = (IToggleButtonInject) myToggleButton;

            toggleButtonInject.setMySolidColorBrushColorOn(colorOn);
            toggleButtonInject.setMySolidColorBrushColorOff(colorOff);
            toggleButtonInject.setMyThicknessLeftSide(leftSide);
            toggleButtonInject.setMyThicknessRightSide(rightSide);
            toggleButtonInject.setMyThicknessMargin(margin);

            return myToggleButton;
        }
    }
}
