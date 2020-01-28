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

namespace progress_bar {
    /// <summary>
    /// Interaction logic for LoadingBar.xaml
    /// </summary>
    public partial class LoadingBar : MyWindow {

        private int duration;
        public LoadingBar(){
            InitializeComponent();

            closing_pb.IsIndeterminate = false;
        }
        public LoadingBar setText(String _text) {
            text_tb.Text = _text;
            return this;
        }
        public LoadingBar setDuration(int _duration) {
            this.duration = _duration;
            return this;
        }
        public LoadingBar setColor(Brush brushes) {
            closing_pb.Foreground = brushes;
            return this;
        }
        public void animate() {
            Console.WriteLine("animate");
            MyDuration myDuration = new MyDuration();
            MyDoubleAnimation myDoubleAnimation = new MyDoubleAnimation();
            myDuration.setMyDuration(20);
            myDoubleAnimation.setMyDoubleAnimation(200, myDuration);
            closing_pb.BeginAnimation(MyProgressBar.ValueProperty, myDoubleAnimation.getDoubleAnimation());
            ShowDialog();
        }

        private void OnValueChangedClosing_pb(object sender, RoutedPropertyChangedEventArgs<double> e){
            if (closing_pb.Value == closing_pb.Maximum){
                //App.Current.Shutdown();
            }
        }
    }
}
