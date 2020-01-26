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
    /// Interaction logic for FieldHobi.xaml
    /// </summary>
    public partial class FieldHobi : MyUserControl
    {
        public FieldHobi()
        {
            InitializeComponent();
        }

        private void OnCheckedPilihSemua_chk(object sender, RoutedEventArgs e)
        {
            if (pilihSemua_chk.IsChecked != false)
            {
                bermainGame_chk.IsChecked = true;
                bermainMusik_chk.IsChecked = true;
                berolahraga_chk.IsChecked = true;
                membaca_chk.IsChecked = true;
                mendengarkanMusik_chk.IsChecked = true;
                menontonFilm_chk.IsChecked = true;
                menulis_chk.IsChecked = true;
            }
            else
            {
                bermainGame_chk.IsChecked = false;
                bermainMusik_chk.IsChecked = false;
                berolahraga_chk.IsChecked = false;
                membaca_chk.IsChecked = false;
                mendengarkanMusik_chk.IsChecked = false;
                menontonFilm_chk.IsChecked = false;
                menulis_chk.IsChecked = false;

            }

        }

    }
}
