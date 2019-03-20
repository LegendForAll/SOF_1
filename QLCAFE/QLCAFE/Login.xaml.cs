using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using QLCAFE_VM;

namespace QLCAFE
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Window_closing);
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            LoginVM loginVM = new LoginVM();
            if (loginVM.Login(tbUserName.Text, pbPassword.Password))
            {
                MessageBox.Show("Hello " + tbUserName.Text, "Infomation", MessageBoxButton.OK, MessageBoxImage.Information);
                Closing -= new CancelEventHandler(Window_closing);
                Close();                
            }               
            else
                MessageBox.Show("Sai ten username hoac password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Window_closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }       
    }
}
