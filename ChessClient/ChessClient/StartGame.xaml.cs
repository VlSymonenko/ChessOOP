using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Interaction logic for StartGame.xaml
    /// </summary>
    public partial class StartGame : Window
    {
        public StartGame()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Game will start between {textBox1.Text} and {textBox2.Text} . Good Luck !!");
            Process.Start(@"C:\Chess1\Output\Wi\Wi.exe");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (var p in Player.Players)
                MessageBox.Show(p.ToString());
            Close();
        }
    }
}
