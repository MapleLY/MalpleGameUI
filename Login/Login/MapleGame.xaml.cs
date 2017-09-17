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
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// MapleGame.xaml 的交互逻辑
    /// </summary>
    public partial class MapleGame : Window
    {
        MainWindow mainwindow;
        public MapleGame(MainWindow mainwindow)
        {
            this.mainwindow = mainwindow;
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mainwindow.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.Show();
            this.Hide();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameBuy gamebuy = new GameBuy();
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"D:\Study\自己做的软件\WPF试验区\登录界面\Login\Login\NBA.jpg", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            gamebuy.photoShow.Source = bi;
            gamebuy.priceShow.Text = "¥88";
            gamebuy.gameShow.Text = "《NBA 2K17》是由Visual Concepts制作、2K Games发行一款篮球竞技类游戏，于2016年9月20日起正式发售，属于《NBA 2K》系列的第17代作品。";
            gamebuy.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            GameBox gamebox = new GameBox();
            gamebox.Show();
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            GameBuy gamebuy = new GameBuy();
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"D:\Study\自己做的软件\WPF试验区\登录界面\Login\Login\D'ont starve together.jpg", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            gamebuy.photoShow.Source = bi;
            gamebuy.priceShow.Text = "¥19";
            gamebuy.gameShow.Text = "《饥荒》是由Klei Entertainment开发的一款动作冒险类求生游戏，游戏讲述的是关于一名科学家被恶魔传送到了一个神秘的世界，玩家将在这个异世界生存并逃出这个异世界的故事。[2]  资料片：船难讲述了一名科学家在一次出海中船只失事，被冲到某岛上，要在这个群岛中生存并逃出生天的故事。";
            gamebuy.Show();
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            GameBuy gamebuy = new GameBuy();
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"D:\Study\自己做的软件\WPF试验区\登录界面\Login\Login\CS go.jpg", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            gamebuy.photoShow.Source = bi;
            gamebuy.priceShow.Text = "¥56";
            gamebuy.gameShow.Text = "《反恐精英：全球攻势》（简称CS:GO）是一款由VALVE与Hidden Path Entertainment合作开发的第一人称射击游戏，游戏玩家分为反恐精英（CT阵营）与恐怖份子（T阵营）两个阵营，双方需在一个地图上进行多回合的战斗，达到地图要求目标或消灭全部敌方则取得胜利。";
            gamebuy.Show();
        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            GameBuy gamebuy = new GameBuy();
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"D:\Study\自己做的软件\WPF试验区\登录界面\Login\Login\left 4 dead.jpg", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            gamebuy.photoShow.Source = bi;
            gamebuy.priceShow.Text = "¥55";
            gamebuy.gameShow.Text = "《求生之路》（Left 4 Dead，简称L4D，又译“生死四人组”、“生存之旅”，港台地区译为“恶灵势力”）是一款以僵尸为主题的恐怖生存类第一人称射击游戏";
            gamebuy.Show();
        }

        private void Image_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            GameBuy gamebuy = new GameBuy();
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"D:\Study\自己做的软件\WPF试验区\登录界面\Login\Login\grand theft auto.jpg", UriKind.RelativeOrAbsolute);
            bi.EndInit();
            gamebuy.photoShow.Source = bi;
            gamebuy.priceShow.Text = "¥168";
            gamebuy.gameShow.Text = "《侠盗猎车手5》（Grand Theft Auto V），是由Rockstar Games游戏公司出版发行的一款围绕犯罪为主题的开放式动作冒险游戏。游戏背景洛圣都基于现实地区中的美国洛杉矶和加州南部制作，游戏拥有几乎与现实世界相同的世界观。玩家可扮演三位主角并在任意时刻进行切换，每位主角都有自己独特的人格与故事背景，以及交织的剧情。";
            gamebuy.Show();
        }


    }
}
