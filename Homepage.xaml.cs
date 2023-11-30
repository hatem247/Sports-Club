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
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Page
    {
        SportsclubDBEntities1 db = new SportsclubDBEntities1();
        Player P = new Player();
        Trainer T = new Trainer();
        public Homepage()
        {
            InitializeComponent();
            
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            if(UsertypeComBox.Text == "Player")
            {
                Dataview.ItemsSource = db.Players.Where(x => x.Player_Name.Contains(Searchtxtbox.Text)).ToList();
            }
            else if (UsertypeComBox.Text == "Trainer")
            {
                Dataview.ItemsSource = db.Trainers.Where(x => x.Trainer_Name.Contains(Searchtxtbox.Text)).ToList();
            }
            else
            {
                MessageBox.Show("Something is wrong :(");
            }
        }
    }
}
