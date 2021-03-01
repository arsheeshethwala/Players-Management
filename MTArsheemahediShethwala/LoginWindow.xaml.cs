using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MTArsheemahediShethwala
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        //public List<User> users = new List<User>();
        Dictionary<String, User> users = new Dictionary<string, User>();

        Boolean login = false, key = false;
        int temp;

        public LoginWindow()
        {
            InitializeComponent();
            users.Add("iamgood", new User(12, "iamgood", "goodisme"));
            users.Add("cricketgod", new User(10, "cricketgod", "sachin"));
            users.Add("rohitsharma", new User(78, "rohitsharma", "mumbaimerijaan"));
            users.Add("ganguly", new User(15, "ganguly", "dada"));
            users.Add("msdhoni", new User(777, "msdhoni", "iamthala"));
            users.Add("admin", new User(101, "admin", "admin"));
            users.Add("root", new User(100, "root", "root"));
            users.Add("shethwaa", new User(991590002, "shethwaa", "shethwaa"));

        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (studentId.Text.Equals("") || userName.Text.Equals("") || passWord.Text.Equals("") || !int.TryParse(studentId.Text, out temp))
            {
                MessageBox.Show("Enter required detais correctly to login! ");
            }
            else
            {
                foreach (var u in users)
                {
                    if(u.Key.Equals(userName.Text))
                    {
                        key = true;
                        if (int.Parse(studentId.Text) == u.Value.Id && u.Value.Username.Equals(userName.Text.ToLower()) && u.Value.Password.Equals(passWord.Text.ToLower()))
                        {
                            login = true;
                        }
                    }
                    
                }
                if (login == true)
                {
                    MainWindow mw = new MainWindow(userName.Text);
                    mw.Show();
                    Close();
                }
                else if(key == true)
                {
                    MessageBox.Show("ID, Username and Password does not match. Login Failed!");
                }
                else
                {
                    MessageBox.Show("Access Denied! Non-registered User!");
                }

               /* studentId.Text = " ";
                userName.Text = " ";
                passWord.Text = " ";*/
            }
            
        }

    }
}
