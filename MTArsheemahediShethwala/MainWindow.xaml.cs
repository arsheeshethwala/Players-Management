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

namespace MTArsheemahediShethwala
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String _username;
        public MainWindow(String _username)
        {
            InitializeComponent();
            this._username = _username;
            name.Content = "Welcome, " + _username;
            Program.Start();
        }

        private void Sign_Out(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sign Out Successfull");
            LoginWindow lw = new LoginWindow();
            lw.Show();
            Close();
        }

        private void Button_Help(object sender, RoutedEventArgs e)
        {

            HelpWindow hw = new HelpWindow();
            hw.ShowDialog();
        }

        private void Button_Hockey(object sender, RoutedEventArgs e)
        {
            IceHockeyPlayerWindow hpw = new IceHockeyPlayerWindow();
            hpw.ShowDialog();
            //Close();
        }

        private void Button_Basketball(object sender, RoutedEventArgs e)
        {
            BasketballPlayerWindow bkpw = new BasketballPlayerWindow();
            bkpw.ShowDialog();
            //Close();
        }

        private void Button_Baseball(object sender, RoutedEventArgs e)
        {
            BaseballPlayerWindow bspw = new BaseballPlayerWindow();
            bspw.ShowDialog();
            //Close();
        }
    }
}
