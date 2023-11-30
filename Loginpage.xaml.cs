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

namespace Sports_Club
{
    /// <summary>
    /// Interaction logic for Loginpage.xaml
    /// </summary>
    public partial class Loginpage : Page
    {
        SportsclubDBEntities1 db = new SportsclubDBEntities1();
        Playerlogin PL = new Playerlogin();
        Trainerlogin TL = new Trainerlogin();
        public Loginpage()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (UsertypeComBox.Text == "")
            {
                MessageBox.Show("Please Choose the user type :)");
            }
            else if (UsertypeComBox.SelectedItem.ToString() != "")
            {
                foreach (var x in db.Playerlogins)
                {
                    if (Usernametxtbox.Text == x.Player_User_Name && Passwordtxtbox.Text == x.Player_Password && UsertypeComBox.Text == "Player")
                    {
                        Homepage hp = new Homepage();
                        NavigationService.Navigate(hp);
                    }
                }
                foreach (var y in db.Trainerlogins)
                {
                    if (Usernametxtbox.Text == y.Trainer_User_Name && Passwordtxtbox.Text == y.Trainer_Password && UsertypeComBox.Text == "Trainer")
                    {
                        Homepage hp = new Homepage();
                        NavigationService.Navigate(hp);
                    }
                }
            }
            else
            {
                MessageBox.Show("Something is Wrong");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ForgetPasswordpage fpp = new ForgetPasswordpage();
            NavigationService.Navigate(fpp);
        }
    }
}
