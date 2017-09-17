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
    /// GameBox.xaml 的交互逻辑
    /// </summary>
    public partial class GameBox : Window
    {
        public GameBox()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.textTitle.Text = "OverWatch";
            this.textArticle.Text = "中文名：《守望先锋》\n暴雪首款团队射击游戏，23名特点鲜明的英雄角色，带来全新6v6游戏体验。游戏以未来地球为背景，讲述人类、守望先锋成员和智能机械的恩怨纠葛。游戏拥有23位英雄，每一位英雄都有各自标志性的武器和技能。";
        }

        private void ListViewItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            this.textTitle.Text = "Left 4 Dead";
            this.textArticle.Text = "中文名：《求生之路》\n一款以僵尸为主题的恐怖生存类第一人称射击游戏，由维尔福软件公司旗下的Turtle Rock工作室制作。此游戏使用的是Source引擎，有个人电脑和Xbox 360版本。Left 4 Dead分别在2008年11月18日和11月21日在美国和欧洲上市。";
        }

        private void ListViewItem_MouseDoubleClick_2(object sender, MouseButtonEventArgs e)
        {
            this.textTitle.Text = "The Witcher";
            this.textArticle.Text = "中文名：《巫师》\n依照波兰籍奇幻小说作家 Andrzej Sapkowski 所写的故事内容来设定的，一款PC平台的ARPG。风格类似于《地牢围攻》、《哥特王朝》和《无冬之夜》，简单有趣的游戏系统和大量引人入胜的3D画面是本作呈献给广大老玩家群体的一款礼物。游戏主角是一位从小接受剑术训练的魔物猎人，以替居民猎杀怪物赚取佣金维生。这个世界与传统奇幻世界很相似，不同之处在于，这个世界并没有绝对的黑与白。善恶的区别并不那么明显，引人注目的并非针锋相对的英雄和恶魔，而是那些真实而富有个性的普通角色。";
        }

        private void ListViewItem_MouseDoubleClick_3(object sender, MouseButtonEventArgs e)
        {
            this.textTitle.Text = "This War of Mine";
            this.textArticle.Text = "中文名：《这是我的战争》\n一款由波兰的游戏开发商11 Bit Studios制作的2d横版战争游戏，玩家扮演的不是士兵而是平民，在战火连连的城市中生存。玩家得在城市废墟中需找食物、武器、零件等任何可以利用的物品。当然，大部分城市废墟也有其他的幸存者，幸存者有友善的，有邪恶的，也有完全不把玩家放在眼里的，玩家可以选择帮助或者无视那些幸存者，同那些幸存者交易物资，玩家也可以杀死那些幸存者掠夺他们的资源，唯一限制玩家的只有心中的道德约束。";
        }

        private void ListViewItem_MouseDoubleClick_4(object sender, MouseButtonEventArgs e)
        {
            this.textTitle.Text = "Shadow of Mordor";
            this.textArticle.Text = "中文名：《中土世界：暗影魔多》\n该游戏是以J.R.R.托尔金笔下的《指环王》中的奇幻大陆“中土大陆”为背景而制作的游戏。故事设定在了《指环王》之前，玩家将扮演游侠塔里昂，与魔戒的缔造者凯勒布理鹏一起探寻魔戒的诞生之谜，托尔金笔下的许多经典人物均在游戏中有所登场。";
        }

        private void ListViewItem_MouseDoubleClick_5(object sender, MouseButtonEventArgs e)
        {
            this.textTitle.Text = "Skyrim";
            this.textArticle.Text = "中文名：《上古卷轴5：天际》\n游戏设定在《上古卷轴4：湮没》的200年之后。玩家将扮演着人身龙魂的英雄龙裔，踏上将邪恶巨龙奥杜因驱逐至时间尽头的征途。";
        }

    }
}
