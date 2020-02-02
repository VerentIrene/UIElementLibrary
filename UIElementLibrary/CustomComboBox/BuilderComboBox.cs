using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIElementLibrary.BaseComponent;
using UIElementLibrary.MyEnum;

namespace UIElementLibrary.CustomComboBox
{
    public class BuilderComboBox 
    {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        private IMyThickness myThickness = new MyThickness();
        private IMyVerticalAlignment myVerticalAlignment = new MyVerticalAlignment();
        private IMyHorizontalAlignment myHorizontalAlignment = new MyHorizontalAlignment();

        public BuilderComboBox() { }
        
        public IBaseComboBox buildBaseComboBox()
        {
            IBaseComboBox baseComboBox = new BaseComboBox();
            IBaseComboBoxInject baseComboBoxInject = (IBaseComboBoxInject)baseComboBox;

            baseComboBoxInject.setMySolidColorBrush(mySolidColorBrush);
            baseComboBoxInject.setMyThickness(myThickness);
            baseComboBoxInject.setMyHorizontalAlignment(myHorizontalAlignment);
            baseComboBoxInject.setMyVerticalAlignment(myVerticalAlignment);

            return baseComboBox;
        }
    }
}
