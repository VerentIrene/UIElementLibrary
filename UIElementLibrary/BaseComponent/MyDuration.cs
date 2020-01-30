using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UIElementLibrary.BaseComponent
{
    public class MyDuration : IMyDuration
    {
        private Duration duration;

        public MyDuration()
        {
            
        }

        public void setMyDuration(double _second)
        {
            this.duration = new Duration(TimeSpan.FromSeconds(_second));
        }

        public Duration getMyDuration()
        {
            return this.duration;
        }

    }
}
