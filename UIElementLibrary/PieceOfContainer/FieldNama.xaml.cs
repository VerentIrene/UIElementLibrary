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
    /// Interaction logic for FieldNama.xaml
    /// </summary>
    public partial class FieldNama : UserControl
    {
        public FieldNama()
        {
            InitializeComponent();
        }

        public void ValidasiHuruf(object sender, TextCompositionEventArgs e)
        {
            MyRegex regex = new MyRegex("[^a-zA-Z]");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
