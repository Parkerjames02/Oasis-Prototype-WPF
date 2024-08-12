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
using System.Media;

namespace Oasis_Prototype__WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int oceanAudioStatus = 0;
        int whiteAudioStatus = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        // Exercise menu buttons
        private void breathingExercisesButton_Click(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 1;
        }

        private void seatedExercisesButton_Click(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 2;
        }

        private void fullBodyExercisesbutton_Click(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 3;
        }
        // Back to exercise main menu button
        private void backToExercisesbutton_Click(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 0;
        }
        // Re-enable all exercise buttons
        private void reenableExerciseButtons()
        {
            deepBreathingButton.IsEnabled = true;
            sitaliBreathingButton.IsEnabled = true;
            modifiedLionsBreathbutton.IsEnabled = true;
            hummingBeeBreathingbutton.IsEnabled = true;
            equalTimeBreathingbutton.IsEnabled = true;
            alternateNostrilBreathingbutton.IsEnabled = true;
            pusredLipBreathingbutton.IsEnabled = true;
            resonantBreathingButton.IsEnabled = true;
        }
        // Breathing exercise buttons
        private void deepBreathingButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Deep Breathing";
            reenableExerciseButtons();
            deepBreathingButton.IsEnabled = false;
        }
        private void sitaliBreathingButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Sitali Breathing";
            reenableExerciseButtons();
            sitaliBreathingButton.IsEnabled = false;
        }
        // Seated exercise buttons
        // Full body exercise buttons
        private void wavesVideoButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
        // Re-enable all audio selection buttons
        // Re-enable all audio preview buttons
        private void reenableAudioPreviewbuttons()
        {
            whiteAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            whiteAudioStatus = 0;
            oceanAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            oceanAudioStatus = 0;
        }
        private void whiteAudioButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void whiteAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playsound = new SoundPlayer();
            if (whiteAudioStatus == 0)
            {
                playsound.SoundLocation = @"Resources\Audio\White Audio.wav";
                playsound.Load();
                playsound.PlayLooping();
                reenableAudioPreviewbuttons();
                whiteAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                whiteAudioStatus = 1;
            }
            else if (whiteAudioStatus == 1)
            {
                playsound.Stop();
                whiteAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                whiteAudioStatus = 0;
            }
        }
        private void oceanAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playsound = new SoundPlayer();
            if (oceanAudioStatus == 0)
            {
                playsound.SoundLocation = @"Resources\Audio\Ocean Audio.wav";
                playsound.Load();
                playsound.PlayLooping();
                reenableAudioPreviewbuttons();
                oceanAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                oceanAudioStatus = 1;
            }
            else if (oceanAudioStatus == 1)
            {
                playsound.Stop();
                oceanAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                oceanAudioStatus = 0;
            }
        }
    }
}


