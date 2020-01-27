using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIElementLibrary.BaseComponent
{
    public class MyColor 
    {
        private Color color;

        public MyColor() { 
        }

        public void setMyColor(byte r, byte g, byte b)
        {
            this.color = Color.FromRgb(r, g, b);
        }

        public Color getMyColor()
        {
            return this.color;
        }
    }
}
