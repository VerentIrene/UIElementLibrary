using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIElementLibrary.BaseComponent;
using UIElementLibrary.MyEnum;

namespace UIElementLibrary.CustomInputField
{
    public class BuilderInputField
    {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        private IMyThickness myThickness = new MyThickness();
        private IMyVerticalAlignment myVerticalAlignment = new MyVerticalAlignment();
        private IMyHorizontalAlignment myHorizontalAlignment = new MyHorizontalAlignment();

        public BuilderInputField() { }
        
        public IBaseInputField buildBaseInputField(){
            IBaseInputField baseInputField = new BaseInputField();

            IBaseInputFieldInject baseInputFieldInject = (IBaseInputFieldInject)baseInputField;
            baseInputFieldInject.setMySolidColorBrush(mySolidColorBrush);
            baseInputFieldInject.setMyThickness(myThickness);
            baseInputFieldInject.setMyHorizontalAlignment(myHorizontalAlignment);
            baseInputFieldInject.setMyVerticalAlignment(myVerticalAlignment);

            return baseInputField;
        }
    } 
}
