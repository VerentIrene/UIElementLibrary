using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace UIElementLibrary.BaseComponent
{
    public class MyMessageBox : MyWindow
    {
        public MyMessageBox()
        {
            ModifyBaseWindow();
        }

        public void ModifyBaseWindow()
        {
            this.Height = 200;
            this.Width = 390;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Background = Brushes.White;
            this.ResizeMode = ResizeMode.NoResize;
            this.BorderThickness = new Thickness(1);
            this.BorderBrush = Brushes.LightGray;
            this.AllowsTransparency = true;
            this.WindowStyle = WindowStyle.None;
            this.SizeToContent = SizeToContent.Height;

        }
    }
}
