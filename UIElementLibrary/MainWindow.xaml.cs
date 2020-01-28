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
using UIElementLibrary.CustomMessageBox;
using UIElementLibrary.CutomMessageBox;

namespace UIElementLibrary
{
    public partial class MainWindow : Window
    {
        MessageBoxTwoButton test1 = new BuilderMessageBox().buildMessageBoxTwoButton();

        public MainWindow()
        {
            InitializeComponent();
            test1.showMessageBox();
            test1.addButton2EventHandler(OnClickCancel_btn);
        }
        private void OnClickCancel_btn(object sender, RoutedEventArgs e)
        {
            test1.Close();
        }

    }
}
