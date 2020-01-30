using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UIElementLibrary.BaseComponent
{
    public interface IMyDuration
    {
        void setMyDuration(double _second);

        Duration getMyDuration();
    }
}
