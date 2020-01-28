using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIElementLibrary.CustomInputField
{
    public class BuilderInputField
    {
        public BuilderInputField() { }
        
        public BaseInputField buildBaseInputField(){
            BaseInputField baseInputField = new BaseInputField();
            return baseInputField;
        }
    }
}
