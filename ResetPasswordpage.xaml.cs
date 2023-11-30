using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for ResetPasswordpage.xaml
    /// </summary>
    public partial class ResetPasswordpage : Page
    {
        SportsclubDBEntities1 db = new SportsclubDBEntities1();
        ForgetPasswordpage fpp = new ForgetPasswordpage();
        Playerlogin PL = new Playerlogin();
        Trainerlogin TL = new Trainerlogin();
        public ResetPasswordpage()
        {
            InitializeComponent();
        }

        private void Confrimbtn_Click(object sender, RoutedEventArgs e)
        {
            if (fpp.UsertypeComBox.Text == "Player")
            {
                if(Passwordtxtbox.Text == "")
                {
                    MessageBox.Show("Password Can't be null :)");
                }
                if(Confirmtxtbox.Text == Passwordtxtbox.Text)
                {
                    PL.Player_Password = Passwordtxtbox.Text;
                    db.Playerlogins.AddOrUpdate(PL);
                    db.SaveChanges();
                    MessageBox.Show("Password Updated Successfully :)");
                }
                else if(Confirmtxtbox.Text != Passwordtxtbox.Text)
                {
                    MessageBox.Show("Password not Matching :(");
                }
                else
                {
                    MessageBox.Show("Something is wrong :(");
                }
            }
            else if(fpp.UsertypeComBox.Text == "Trainer")
            {
                if (Passwordtxtbox.Text == "")
                {
                    MessageBox.Show("Password Can't be null :)");
                }
                if (Confirmtxtbox.Text == Passwordtxtbox.Text)
                {
                    TL.Trainer_Password = Passwordtxtbox.Text;
                    db.Trainerlogins.AddOrUpdate(TL);
                    MessageBox.Show("Password Updated Successfully :)");
                }
                else if (Confirmtxtbox.Text != Passwordtxtbox.Text)
                {
                    MessageBox.Show("Password not Matching :(");
                }
                else
                {
                    MessageBox.Show("Something is wrong :(");
                }
            }
            else
            {
                MessageBox.Show("Something is wrong :(");
            }
        }
    }
}
