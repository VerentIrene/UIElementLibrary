using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIElementLibrary.CutomMessageBox;

namespace UIElementLibrary.CustomMessageBox
{
    public class BuilderMessageBox {
        public BuilderMessageBox(){

        }

        public BaseMessageBox buildBaseMessageBox(){
            BaseMessageBox myMessageBox = new BaseMessageBox();
            return myMessageBox;
        }

        public MessageBoxTwoButton buildMessageBoxTwoButton(){
            MessageBoxTwoButton myMessageBox = new MessageBoxTwoButton();
            return myMessageBox;
        }
    }
}
