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
    /// Interaction logic for ForgetPasswordpage.xaml
    /// </summary>
    public partial class ForgetPasswordpage : Page
    {
        SportsclubDBEntities1 db = new SportsclubDBEntities1();
        Playerlogin PL = new Playerlogin();
        Trainerlogin TL = new Trainerlogin();
        ResetPasswordpage rpp = new ResetPasswordpage();
        public ForgetPasswordpage()
        {
            InitializeComponent();
        }

        private void SumbitNicknamebtn_Click(object sender, RoutedEventArgs e)
        {
            if(UsertypeComBox.Text == "Player")
            {
                foreach(var x in db.Playerlogins)
                {
                    if(Usernametxtbox.Text == x.Player_User_Name && Nicknametxtbox.Text == x.Player_Nick_Name)
                    {
                        NavigationService.Navigate(rpp);
                    }
                    else if(Usernametxtbox.Text != x.Player_User_Name || Nicknametxtbox.Text != x.Player_Nick_Name)
                    {
                        MessageBox.Show("Username ro Nickname is wrong :(");
                    }
                    else
                    {
                        MessageBox.Show("Something is wrong :(");
                    }
                }
            }
            else if (UsertypeComBox.Text == "Player")
            {
                foreach (var x in db.Trainerlogins)
                {
                    if (Usernametxtbox.Text == x.Trainer_User_Name && Nicknametxtbox.Text == x.Trainer_Nick_Name)
                    {
                        NavigationService.Navigate(rpp);
                    }
                    else if (Usernametxtbox.Text != x.Trainer_User_Name || Nicknametxtbox.Text != x.Trainer_Nick_Name)
                    {
                        MessageBox.Show("Username ro Nickname is wrong :(");
                    }
                    else
                    {
                        MessageBox.Show("Something is wrong :(");
                    }
                }
            }
            else
            {
                MessageBox.Show("Something is Wrong :(");
            }
        }
    }
}
