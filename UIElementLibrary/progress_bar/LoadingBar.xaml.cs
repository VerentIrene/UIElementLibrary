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
using UIElementLibrary.progress_bar;

namespace progress_bar {

    public partial class LoadingBar : MyWindow, ILoadingBarInject, ILoadingBar {

        private int duration;
        private IMySolidColorBrush mySolidColorBrush;
        private IMyDuration myDuration;
        private IMyDoubleAnimation myDoubleAnimation;

        public LoadingBar(){
            InitializeComponent();

            closing_pb.IsIndeterminate = false;
        }

        public void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush) {
            this.mySolidColorBrush = _mySolidColorBrush;
        }

        public void setMyDuration(IMyDuration _myDuration) {
            this.myDuration = _myDuration;
        }

        public void setMyDoubleAnimation(IMyDoubleAnimation _myDoubleAnimation) {
            this.myDoubleAnimation = _myDoubleAnimation;
        }

        public LoadingBar setText(String _text, String _color) {
            text_tb.Text = _text;
            text_tb.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }
        public LoadingBar setDuration(int _duration) {
            this.duration = _duration;
            return this;
        }
        public LoadingBar setColor(String _color) {
            closing_pb.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public void animate() {
            myDuration.setMyDuration(20);
            myDoubleAnimation.setMyDoubleAnimation(200, myDuration);
            closing_pb.BeginAnimation(MyProgressBar.ValueProperty, myDoubleAnimation.getDoubleAnimation());
            ShowDialog();
        }

        private void OnValueChangedClosing_pb(object sender, RoutedPropertyChangedEventArgs<double> e){
            if (closing_pb.Value == closing_pb.Maximum){
                this.Close();
            }
        }

    }
}
