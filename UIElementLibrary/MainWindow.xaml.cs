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
using UIElementLibrary.custom_toggle_button;
using UIElementLibrary.CustomComboBox;
using UIElementLibrary.CustomInputField;
using UIElementLibrary.CustomMessageBox;
using UIElementLibrary.CutomMessageBox;

namespace UIElementLibrary
{
    public partial class MainWindow : Window
    {
        CustomToggleButton toggleButton = new BuilderToggleButton().buildCustomToggleButton().init();
        BaseInputField nama_field = new BuilderInputField().buildBaseInputField().init();
        BaseInputField nrp_field = new BuilderInputField().buildBaseInputField().init();
        BaseComboBox combo_field = new BuilderComboBox().buildBaseComboBox().init();
        public MainWindow()
        {
            InitializeComponent();

            //new BuilderMessageBox()
            //    .buildBaseMessageBox()
            //    .setTitle("Test", "black")
            //    .showMessageBox();

            //mainGrid.Children.Add(toggleButton);
            //ICustomToggleButton customToggleButton = toggleButton;
            //customToggleButton.setColorOn("green");
            //customToggleButton.setSize(42, 36);
            //customToggleButton.setLocation(0, 220);

            mainGrid.Children.Add(nrp_field);
            IBaseInputField customNrpField = nrp_field;
            customNrpField.setTextBoxSize(170, 25);
            customNrpField.setLabelText("Nrp", "black");
            customNrpField.setLocation(16, 20);
            customNrpField.addTextBoxEventHandler(ValidasiAngka);

            mainGrid.Children.Add(nama_field);
            IBaseInputField customNamaField = nama_field;
            customNamaField.setTextBoxSize(170, 25);
            customNamaField.setLabelText("Nama", "black");
            customNamaField.setLocation(16, 50);
            customNamaField.addTextBoxEventHandler(ValidasiHuruf);

            MyList<string> ItemList = new MyList<string>();
            String[] agama = { "Islam", "Kristen", "Katolik", "Hindu", "Buddha", "Konghucu" };

            ItemList.AddRange(agama);


            mainGrid.Children.Add(combo_field);
            IBaseComboBox customComboField = combo_field;
            customComboField.setComboBoxSize(170, 25);
            customComboField.setLabelText("Test", "black");
            customComboField.setLocation(16, 80);
            customComboField.addItemList(ItemList);
            //customComboField.addItem("Tony");
            //customComboField.addItem("Stark");

        }

        public void ValidasiHuruf(object sender, TextCompositionEventArgs e)
        {
            MyRegex regex = new MyRegex("[^a-zA-Z]");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void ValidasiAngka(object sender, TextCompositionEventArgs e)
        {
            MyRegex regex = new MyRegex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
