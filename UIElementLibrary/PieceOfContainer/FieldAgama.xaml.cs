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
    /// Interaction logic for FieldAgama.xaml
    /// </summary>
    public partial class FieldAgama : MyUserControl
    {
        public FieldAgama()
        {
            InitializeComponent();
            LoadDataCbAgama();
            if (agama_cbo.SelectedItem == null)
            {
                agama_cbo.SelectedItem = agama_cbo.Items[0];
            }
        }
        public void LoadDataCbAgama()
        {
            MyList<string> ItemList = new MyList<string>();
            String[] agama = { "Islam", "Kristen", "Katolik", "Hindu", "Buddha", "Konghucu" };

            ItemList.AddRange(agama);
            agama_cbo.ItemsSource = ItemList;
        }

    }
}
