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
    /// Interaction logic for ProgressBarControl.xaml
    /// </summary>
    public partial class ProgressBarControl : MyWindow {
        public ProgressBarControl(){
            InitializeComponent();

            closing_pb.IsIndeterminate = false;
            Duration duration = new Duration(TimeSpan.FromSeconds(20));
            DoubleAnimation doubleanimation = new DoubleAnimation(200, duration);
            closing_pb.BeginAnimation(MyProgressBar.ValueProperty, doubleanimation);
        }

        private void OnValueChangedClosing_pb(object sender, RoutedPropertyChangedEventArgs<double> e){
            if (closing_pb.Value == closing_pb.Maximum){
                App.Current.Shutdown();
            }
        }
    }
}
