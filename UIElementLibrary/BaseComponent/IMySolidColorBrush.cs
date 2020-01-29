using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace UIElementLibrary.BaseComponent
{
    public interface IMySolidColorBrush
    {
        void setMySolidColorBrush(Color _color);

        SolidColorBrush getMySolidColorBrush();

        SolidColorBrush setMyConverter(String _color);
    }
}
