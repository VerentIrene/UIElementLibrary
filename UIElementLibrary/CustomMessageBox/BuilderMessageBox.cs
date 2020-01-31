using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIElementLibrary.BaseComponent;
using UIElementLibrary.CutomMessageBox;

namespace UIElementLibrary.CustomMessageBox
{
    public class BuilderMessageBox {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();

        public BuilderMessageBox(){

        }

        public IBaseMessageBox buildBaseMessageBox(){
            IBaseMessageBox myMessageBox = new BaseMessageBox();
            IMessageBoxInject messageBoxInject = (IMessageBoxInject) myMessageBox;
            messageBoxInject.setMySolidColorBrush(mySolidColorBrush);

            return myMessageBox;
        }

        public IMessageBoxTwoButton buildMessageBoxTwoButton(){
            IMessageBoxTwoButton myMessageBox = new MessageBoxTwoButton();
            IMessageBoxInject messageBoxInject = (IMessageBoxInject)myMessageBox;
            messageBoxInject.setMySolidColorBrush(mySolidColorBrush);

            return myMessageBox;
        }
    }
}
