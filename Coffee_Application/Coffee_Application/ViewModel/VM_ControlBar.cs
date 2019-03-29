using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;


namespace Coffee_Application.ViewModel
{
    public class VM_ControlBar: BaseViewModel
    {
        #region commands
        public ICommand cm_CloseWindow { get; set; }
        public ICommand cm_MaximizeWindow { get; set; }
        public ICommand cm_MinimizeWindow { get; set; }
        public ICommand cm_MousemoveWindow { get; set; }
        #endregion

        public VM_ControlBar()
        {
            // command close window
            cm_CloseWindow = new RelayCommand<UserControl>((p)=> { return p == null ? false: true; }, (p) => {
                FrameworkElement window =  getWindowParent(p);
                var w = window as Window;
                if(w != null)
                {
                    w.Close();
                }
            });

            // command maximize window
            cm_MaximizeWindow = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = getWindowParent(p);
                var w = window as Window;
                if(w != null)
                {
                    if(w.WindowState != WindowState.Maximized)
                    {
                        w.WindowState = WindowState.Maximized;
                    }
                    else
                    {
                        w.WindowState = WindowState.Normal;
                    }
                }
            });

            // command minimize window
            cm_MinimizeWindow = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = getWindowParent(p);
                var w = window as Window;
                if(w != null)
                {
                    if(w.WindowState != WindowState.Minimized)
                    {
                        w.WindowState = WindowState.Minimized;
                    }
                    else
                    {
                        w.WindowState = WindowState.Maximized;
                    }
                }
            });

            // command event mouse move window
            cm_MousemoveWindow = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = getWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    w.DragMove();
                }
            });
        }

        //get parent window for control window
        FrameworkElement getWindowParent(UserControl p)
        {
            FrameworkElement parent = p;
            //loop find window
            while(parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }
            return parent;
        }
    }
}
