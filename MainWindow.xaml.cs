using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;

namespace BonkaLottning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        public MainWindow()
        {
            InitializeComponent();

            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);

            List<TextBlock> textBlocks = new List<TextBlock>()
            {
                textBlock1,
                textBlock2,
                textBlock3,
                textBlock4
            };

            List<Image> crossImage = new List<Image>()
            {
                Cross
            };

            ShowTextBlocksWithDelay(textBlocks);
            ShowCrossWithDelay(crossImage);

            
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void lottningButton_Click(object sender, RoutedEventArgs e)
        {
            Lottning LottningWindow = new Lottning();
            LottningWindow.Show();
            this.Close();
            
        }

        private void ShowTextBlocksWithDelay(List<TextBlock> textBlocks)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1500);

            timer.Start();

            int index = 0;
            timer.Tick += (sender, e) =>
            {
                textBlocks[index].Visibility = Visibility.Visible;
                index++;

                if (index == textBlocks.Count)
                {
                    timer.Stop();
                }
            };

            
        }

        private void ShowCrossWithDelay(List<Image> crossImage)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(9000);
                        
            timer.Tick += (sender, e) =>
            Cross.Visibility = Visibility.Visible;
            
            timer.Stop();
            timer.Start();
        }
    }
}
