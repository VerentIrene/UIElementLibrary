using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIElementLibrary.BaseComponent;
using UIElementLibrary.progress_bar;

namespace progress_bar
{
    public class BuilderLoadingBar
    {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        private IMyDuration myDuration = new MyDuration();
        private IMyDoubleAnimation myDoubleAnimation = new MyDoubleAnimation();

        public BuilderLoadingBar()
        {

        }

        public ILoadingBar buildLoadingBar()
        {
            ILoadingBar loadingBar = new LoadingBar();
            ILoadingBarInject loadingBarInject = (ILoadingBarInject)loadingBar;

            loadingBarInject.setMyDoubleAnimation(myDoubleAnimation);
            loadingBarInject.setMyDuration(myDuration);
            loadingBarInject.setMySolidColorBrush(mySolidColorBrush);

            return loadingBar;
        }
    }
}
