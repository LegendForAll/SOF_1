using Coffee_Application.ViewModel;
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

namespace Coffee_Application.UControl
{
    /// <summary>
    /// Interaction logic for UC_ControlBar.xaml
    /// </summary>
    public partial class UC_ControlBar : UserControl
    {
        // use viewModel differen window
        public VM_ControlBar Viewmodel { get; set; }
        public UC_ControlBar()
        {
            InitializeComponent();
            DataContext = Viewmodel = new VM_ControlBar();
        }
    }
}
