using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIElementLibrary.CustomComboBox
{
    public class BuilderComboBox { 
        public BuilderComboBox() { }
        
        public IBaseComboBox buildBaseComboBox()
        {
            IBaseComboBox baseComboBox = new BaseComboBox();
            return baseComboBox;
        }
    }
}
