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
    /// Interaction logic for FieldPrestasi.xaml
    /// </summary>
    public partial class FieldPrestasi : MyUserControl
    {
        public FieldPrestasi()
        {
            InitializeComponent();
        }
        private void OnClickTambah_btn(object sender, RoutedEventArgs e)
        {
            prestasi_lb.Items.Add(prestasi_txt.Text);
            prestasi_txt.Text = "";
        }

    }
}
