using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Coffee_Application.ViewModel
{
    public class VM_Main: BaseViewModel
    {
        #region commands
        public ICommand cm_LoadedWindow { get; set; }
        #endregion
        //static bool isloaded = false;
        // all processing
        public VM_Main()
        {
            // command loaded window
            cm_LoadedWindow = new RelayCommand<object>((p) => { return true; }, (p) => {
                //isloaded = true;
                V_Login vLogin = new V_Login();
                vLogin.ShowDialog();
            });
        } 
    }
}
