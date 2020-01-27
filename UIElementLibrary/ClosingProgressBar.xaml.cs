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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UIElementLibrary.BaseComponent;

namespace UIElementLibrary{
    /// <summary>
    /// Interaction logic for ClosingProgressBar.xaml
    /// </summary>
    public partial class ClosingProgressBar : MyWindow {
        public ClosingProgressBar(){
            InitializeComponent();

            closing_pb.IsIndeterminate = false;

            MyDuration myDuration = new MyDuration();
            MyDoubleAnimation myDoubleAnimation = new MyDoubleAnimation();

            myDuration.setMyDuration(20);
            myDoubleAnimation.setMyDoubleAnimation(200, myDuration);
            closing_pb.BeginAnimation(MyProgressBar.ValueProperty, myDoubleAnimation.getDoubleAnimation());
        }

        private void OnValueChangedClosing_pb(object sender, RoutedPropertyChangedEventArgs<double> e){
            if (closing_pb.Value == closing_pb.Maximum){
                App.Current.Shutdown();
            }
        }
    }
}
