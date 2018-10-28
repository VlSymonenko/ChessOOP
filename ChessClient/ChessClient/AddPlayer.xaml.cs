using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Window,IComparable<Player>
    {
        public AddPlayer()
        {
            InitializeComponent();
        }
        public int CompareTo(Player p) => CompareTo(p);
        public string CheckNick(string nick)
        {

            foreach (var a in Player.Players)
                if (nick == a.NickName)
                    return "Ghost";
            return nick;
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            Player player = new Player(txtboxName.Text);
            player.Nationality = txtboxNationality.Text;
            player.Rating = Convert.ToInt16(txtboxRating.Text);
            player.SName = txtboxSurname.Text;
            player.Age = Convert.ToInt16(txtboxAge.Text);
            string nick = txtboxNickName.Text;
            player.NickName=CheckNick(nick);
            Player.Players.Add(player);
            MessageBox.Show("Player was succesfully saved");
            //if (Player.CompareTo(player) == 0)
            //{
            //    Player.Players.Add(player);
            //    MessageBox.Show(player.ToString());
            //}
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
