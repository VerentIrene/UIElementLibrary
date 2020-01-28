using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace UIElementLibrary.BaseComponent
{
    public class MySolidColorBrush
    {
        private SolidColorBrush solidColorBrush;

        public MySolidColorBrush() { }

        public void setMySolidColorBrush(Color _color){
            this.solidColorBrush = new SolidColorBrush(_color);
        }

        public SolidColorBrush getMySolidColorBrush(){
            return this.solidColorBrush;
        }

        public SolidColorBrush setMyConverter(String _color){
            this.solidColorBrush = (SolidColorBrush) new BrushConverter().ConvertFromString(_color);
            return this.solidColorBrush;
        }
    }
 }

