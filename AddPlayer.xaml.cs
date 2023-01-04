using Microsoft.Win32;
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

namespace BonkaLottning
{
    /// <summary>
    /// Interaction logic for AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Window
    {
        public AddPlayer()
        {
            InitializeComponent();

        }

        private void AddImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg) |*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                UploadedPreView.Source = new BitmapImage(fileUri);
            }
        }

        void SubmitPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            // PlayerList.Add(new Players { Name = NameInput.Text, Hcp = int.Parse(HcpInput.Text), Skill = int.Parse(SkillInput.Text), PlayerImage = Convert.ToString(UploadedPreView.Source) });
            NameInput.Text = string.Empty;
            HcpInput.Text = string.Empty;
            SkillInput.Text = string.Empty;
            UploadedPreView.Source = null;
        }
    }
}
