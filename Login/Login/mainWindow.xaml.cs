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

namespace Login
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCancle_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            MapleGame maplegame = new MapleGame(this);
            maplegame.Show();
            this.Hide();
        }

        private void ButtonRe_Click(object sender, RoutedEventArgs e)
        {
            MapleRe maplere = new MapleRe();
            maplere.Show();
        }
    }
}
