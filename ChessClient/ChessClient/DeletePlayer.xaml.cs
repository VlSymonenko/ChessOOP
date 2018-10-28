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
    /// Interaction logic for DeletePlayer.xaml
    /// </summary>
    public partial class DeletePlayer : Window
    {
        public DeletePlayer()
        {
            InitializeComponent();
        }

         void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = -1;
            foreach (var p in Player.Players)
                if (p.NickName == txtboxDeleteP.Text)
                    index = Player.Players.IndexOf(p);
            if (index != -1)
            {
                Player.Players.RemoveAt(index);
                MessageBox.Show("Player was succesfully deleted");
            }
            else
                MessageBox.Show("Player wasn't deleted , maybe your data is wrong");
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
