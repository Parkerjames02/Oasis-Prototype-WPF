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

// Updated (8/16/2024)

namespace Oasis_Prototype__WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int wavesVideoStatus = 0;
        int fireVideoStatus = 0;
        int whiteAudioStatus = 0;
        int pinkAudioStatus = 0;
        int oceanAudioStatus = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        SoundPlayer playSound = new SoundPlayer();
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
            //exerciseSelectedTextblock.Text = "Deep Breathing";
            exerciseSelectedTextblock.Text = "Deep Breathing";
            reenableExerciseButtons();
            deepBreathingButton.IsEnabled = false;
        }
        private void sitaliBreathingButton_Click(object sender, RoutedEventArgs e)
        {
            //exerciseSelectedTextblock.Text = "Sitali Breathing";
            exerciseSelectedTextblock.Text = "Sitali Breathing";
            reenableExerciseButtons();
            sitaliBreathingButton.IsEnabled = false;
        }
        // Seated exercise buttons
        // Full body exercise buttons
        // Re-enable all video selection buttons
        private void reenableVideoButtons()
        {
            wavesVideoButton.IsEnabled = true;
            fireVideoButton.IsEnabled = true;
        }
        // Re-enable all video preview buttons
        private void reenableVideoPreviewbuttons()
        {
            wavesVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            wavesVideoStatus = 0;
            fireVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            fireVideoStatus = 0;
        }
        // Code to make the media in the preview media element loop
        private void previewVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            previewVideo.Position = new TimeSpan(0, 0, 1);
            previewVideo.Play();
        }
        // Video selection buttons
        private void wavesVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Waves";
            reenableVideoButtons();
            wavesVideoButton.IsEnabled = false;
        }
        private void wavesVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (wavesVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Waves Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                reenableVideoPreviewbuttons();
                wavesVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                wavesVideoStatus = 1;
            }
            else if (wavesVideoStatus == 1)
            {
                previewVideo.Stop();
                wavesVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                wavesVideoStatus = 0;
            }
        }
        private void fireVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Fire";
            reenableVideoButtons();
            fireVideoButton.IsEnabled = false;
        }
        private void fireVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (fireVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Fire Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                fireVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                fireVideoStatus = 1;
            }
            else if (fireVideoStatus == 1)
            {
                previewVideo.Stop();
                fireVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                fireVideoStatus = 0;
            }
        }
        // Re-enable all audio selection buttons
        private void reenableAudioButtons()
        {
            whiteAudioButton.IsEnabled = true;
            pinkAudioButton.IsEnabled = true;
            oceanAudiobutton.IsEnabled = true;
        }
        // Re-enable all audio preview buttons
        private void reenableAudioPreviewbuttons()
        {
            whiteAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            whiteAudioStatus = 0;
            pinkAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            pinkAudioStatus = 0;
            oceanAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            oceanAudioStatus = 0;
        }
        // Audio selection buttons
        private void whiteAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "White Noise";
            reenableAudioButtons();
            whiteAudioButton.IsEnabled = false;
        }
        private void whiteAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer();
            if (whiteAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\White Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                whiteAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                whiteAudioStatus = 1;
            }
            else if (whiteAudioStatus == 1)
            {
                playSound.Stop();
                whiteAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                whiteAudioStatus = 0;
            }
        }
        private void pinkAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Pink Noise";
            reenableAudioButtons();
            pinkAudioButton.IsEnabled = false;
        }
        private void pinkAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (pinkAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Pink Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                pinkAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                pinkAudioStatus = 1;
            }
            else if (pinkAudioStatus == 1)
            {
                playSound.Stop();
                pinkAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                pinkAudioStatus = 0;
            }
        }
        private void oceanAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Ocean";
            reenableAudioButtons();
            oceanAudiobutton.IsEnabled = false;
        }
        private void oceanAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer();
            if (oceanAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Ocean Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                oceanAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                oceanAudioStatus = 1;
            }
            else if (oceanAudioStatus == 1)
            {
                playSound.Stop();
                oceanAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                oceanAudioStatus = 0;
            }
        }
        // Button to reset the selected exercise
        private void resetExerciseButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "None";
            reenableExerciseButtons();
        }
        // Button to reset the selected video
        private void resetVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "None";
            reenableVideoButtons();
            reenableVideoPreviewbuttons();
            previewVideo.Stop();
        }
        // Button to reset the selected audio
        private void resetAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "None";
            reenableAudioButtons();
            reenableAudioPreviewbuttons();
            playSound.Stop();
        }
        // Code to make the video in the play video media element loop
        private void playVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            playVideo.Position = new TimeSpan(0, 0, 1);
            playVideo.Play();
        }
        // The start button that starts and sends the user over to the custome experience
        private async void startButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseInsturctionsBackground.Visibility = Visibility.Collapsed;
            previewVideo.Stop();
            playSound.Stop();
            reenableVideoPreviewbuttons();
            reenableAudioPreviewbuttons();
            mainTabControl.SelectedIndex = 7;
            exerciseTab.Visibility = Visibility.Collapsed;
            videoTab.Visibility = Visibility.Collapsed;
            audioTab.Visibility = Visibility.Collapsed;
            startTab.Visibility = Visibility.Collapsed;
            // Video selection logic
            if (videoSelectedTextblock.Text != "None")
            {
                if (videoSelectedTextblock.Text == "Waves")
                {
                    playVideo.Source = new Uri("Resources/Video/Waves Video.mp4", UriKind.RelativeOrAbsolute);
                    playVideo.Play();
                    reenableVideoPreviewbuttons();
                }
                else if (videoSelectedTextblock.Text == "Fire")
                {
                    playVideo.Source = new Uri("Resources/Video/Fire Video.mp4", UriKind.RelativeOrAbsolute);
                    playVideo.Play();
                    reenableVideoPreviewbuttons();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            // Audio selection logic
            if (audioSelectedTextblock.Text != "None")
            {
                if (audioSelectedTextblock.Text == "White Noise")
                {
                    playSound.SoundLocation = @"Resources\Audio\White Audio.wav";
                    playSound.Load();
                    playSound.PlayLooping();
                    reenableAudioPreviewbuttons();
                }
                else if (audioSelectedTextblock.Text == "Pink Noise")
                {
                    playSound.SoundLocation = @"Resources\Audio\Pink Audio.wav";
                    playSound.Load();
                    playSound.PlayLooping();
                    reenableAudioPreviewbuttons();
                }
                else if (audioSelectedTextblock.Text == "Ocean")
                {
                    playSound.SoundLocation = @"Resources\Audio\Ocean Audio.wav";
                    playSound.Load();
                    playSound.PlayLooping();
                    reenableAudioPreviewbuttons();
                }
                else if (audioSelectedTextblock.Text == "None")
                {
                    MessageBox.Show("Error");
                }
            }
            // Exercise selection logic
            if (exerciseSelectedTextblock.Text != "None")
            {
                if (exerciseSelectedTextblock.Text == "Deep Breathing")
                {
                    await Task.Delay(3000);
                    exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                    exerciseInsturctionsText.Text = "Your deep breathing exercise will begin now...";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Take a deep inhale through your nose for 4 seconds";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Now exhale through your mouth for 6 seconds";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Nice, let's do that again";
                    await Task.Delay(4000);
                    exerciseInsturctionsText.Text = "Take a deep inhale through your nose for 4 seconds";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Now exhale through your mouth for 6 seconds";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Repeat these steps until you feel relieved";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "";
                    exerciseInsturctionsBackground.Visibility = Visibility.Collapsed;
                }
                else if (exerciseSelectedTextblock.Text == "Sitali Breathing")
                {
                    await Task.Delay(3000);
                    exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                    exerciseInsturctionsText.Text = "Your sitali breathing exercise will begin now...";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Put your tongue against your bottom row of teath";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Now slightly purse your lips and inhale until your lungs are full";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Now close your mouth and fully exhale through your nose";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Great, now let't repeat those steps again";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Make sure that your tongue is against your bottom row of teath";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Now slightly purse your lips and inhale until your lungs are full";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Now close your mouth and fully exhale through your nose";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "Repeat these steps until you feel relieved";
                    await Task.Delay(7000);
                    exerciseInsturctionsText.Text = "";
                    exerciseInsturctionsBackground.Visibility = Visibility.Collapsed;
                }
                else if (exerciseSelectedTextblock.Text == "None")
                {
                    MessageBox.Show("Error");
                }
            }
        }
        // Button that sends the user back to the custom experience customizer menu
        private void backToMainbutton_Click(object sender, RoutedEventArgs e)
        {
            playSound.Stop();
            playVideo.Stop();
            exerciseInsturctionsText.Text = "";
            exerciseInsturctionsBackground.Visibility = Visibility.Collapsed;
            mainTabControl.SelectedIndex = 6;
            exerciseTab.Visibility = Visibility.Visible;
            videoTab.Visibility = Visibility.Visible;
            audioTab.Visibility = Visibility.Visible;
            startTab.Visibility = Visibility.Visible;
        }
    }
}
