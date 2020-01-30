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
using UIElementLibrary.custom_toggle_button;
using UIElementLibrary.CustomInputField;
using UIElementLibrary.CustomMessageBox;
using UIElementLibrary.CutomMessageBox;

namespace UIElementLibrary
{
    public partial class MainWindow : Window
    {
        CustomToggleButton toggleButton = new BuilderToggleButton().buildCustomToggleButton().init();
        public MainWindow()
        {
            InitializeComponent();

            //new BuilderMessageBox()
            //    .buildBaseMessageBox()
            //    .setTitle("Test", "black")
            //    .showMessageBox();

            //mainGrid.Children.Add(toggleButton);
            //ICustomToggleButton customToggleButton = toggleButton;
            //customToggleButton.setColorOn("green");
            //customToggleButton.setSize(42, 36);
            //customToggleButton.setLocation(0, 220);
        }
    }
}
