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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UIElementLibrary.BaseComponent;

namespace UIElementLibrary.PieceOfContainer
{
    /// <summary>
    /// Interaction logic for FieldNRP.xaml
    /// </summary>
    public partial class FieldNRP : MyUserControl
    {
        public FieldNRP()
        {
            InitializeComponent();
        }
        public void ValidasiAngka(object sender, TextCompositionEventArgs e)
        {
            MyRegex regex = new MyRegex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
