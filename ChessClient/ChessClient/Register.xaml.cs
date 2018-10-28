using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChessClient
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            ShowPlayers();
        }

        private void ShowPlayers()
        {
            PlayersList.ItemsSource = Player.Players;
         //   DataContext = this;
          //  Binding binding = new Binding();
         //   binding.ElementName = "";
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer ap = new AddPlayer();
            ap.ShowDialog();
            Close();
        }

        //private void btnSh_Click(object sender, RoutedEventArgs e)
        //{

           
        //}

        private void chnbtn_Click(object sender, RoutedEventArgs e)
        {
            //ChangePlayer cp = new ChangePlayer();
            //cp.ShowDialog();
            Close();
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            DeletePlayer dp = new DeletePlayer();
            dp.ShowDialog();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
