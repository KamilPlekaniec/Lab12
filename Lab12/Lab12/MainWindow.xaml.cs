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
using System.Runtime.InteropServices;
using System.Security;

namespace Lab12
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>()
        {
            new User("maniek12", "mleko123"),
            new User("manio", "123"),
            new User("man", "mleko"),
            new User("12", "m3")
            
        };
        public bool CheckLogin(string login, SecureString password)
        {
            var pwd = default(string);
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(password);
                pwd = Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }

            return (Login == login && Password == pwd);
        }
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void WylogujBTN_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ZalogujBTN_Click(object sender, RoutedEventArgs e)
        {
            ZalogujBTN.Visibility = Visibility.Hidden;
            WylogujBTN.Visibility = Visibility.Visible;
        }

        private void LoginTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
