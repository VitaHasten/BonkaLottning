using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

            this.DataContext = Players.PlayerList;

            OldPlayer.ItemsSource = Players.PlayerList;

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
            string InputOk = "";
            while (InputOk != "OK")
            {
            
                
                if (NameInput.Text != string.Empty && HcpInput != null && SkillInput != null )
                {
                    Player selectedPlayer = (Player)OldPlayer.SelectedItem;
                    Players.PlayerList.Remove(selectedPlayer);

                    
                    // Players.PlayerList.Add( Name = NameInput.Text, Hcp = double.Parse(HcpInput.Text), Skill = int.Parse(SkillInput.Text), Drives = int.Parse(DriverInput.Value), Wedges = int.Parse(WedgeInput.Value), Chipping = int.Parse(ChippingInput.Value), Putting = int.Parse(PuttingInput.Value), Vinnarskalle = int.Parse(VinnarskalleInput.Value), Alcohol = int.Parse(AlcoholInput.Value), PlayerImage = Convert.ToString(UploadedPreView.Source) PlayerFlag = @"/somalia.png" );
                    

                    // Nollställer inmatningarna.
                    NameInput.Text = string.Empty;
                    HcpInput.Text = string.Empty;
                    SkillInput.Text = string.Empty;
                    DriverInput.Value = 3;
                    WedgeInput.Value = 3;
                    ChippingInput.Value = 3;
                    PuttingInput.Value = 3;
                    VinnarskalleInput.Value = 3;
                    AlcoholInput.Value = 3;
                    UploadedPreView.Source = null;
                    OldPlayer.Text = "    -- Välj spelare --";
                    InputOk = "OK";
                }

                else
                {
                    MessageBox.Show("Det saknas information. Fyll i alla fält och ladda upp en bild.");
                }
            
            }
        }
    }
}

