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
        // Initialize the main window of the application
        public MainWindow()
        {
            InitializeComponent();
        }

        // <--- All initialized int variables for status of video and audio resources --->
        // All video int variables
        int wavesVideoStatus = 0;
        int fireVideoStatus = 0;
        int cloudsVideoStatus = 0;
        int caveVideoStatus = 0;
        int starsVideoStatus = 0;
        int mountainVideoStatus = 0;
        int desertVideoStatus = 0;
        int icebergVideoStatus = 0;
        int cityVideoStatus = 0;
        int waterfallVideoStatus = 0;
        int swampVideoStatus = 0;
        int flowersVideoStatus = 0;
        int canyonVideoStatus = 0;
        int bridgeVideoStatus = 0;
        int rainforestVideoStatus = 0;
        // All audio int variables
        int whiteAudioStatus = 0;
        int pinkAudioStatus = 0;
        int windAudioStatus = 0;
        int rainAudioStatus = 0;
        int birdsAudioStatus = 0;
        int cricketsAudioStatus = 0;
        int fireAudioStatus = 0;
        int frogsAudioStatus = 0;
        int chimesAudioStatus = 0;
        int divingAudioStatus = 0;
        int cityAudioStatus = 0;
        int oceanAudioStatus = 0;
        int thunderAudioStatus = 0;
        int shopAudioStatus = 0;
        int leavesAudioStatus = 0;
        int farmAudioStatus = 0;

        // Initialize sound player for the custom stress relief experience tab
        SoundPlayer playSound = new SoundPlayer();

        // <--- All functions for the exercise tab and all of its buttons --->

        // Function that sends the user to the breathing exercise tab
        private void breathingExercisesButton_Click(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 1;
        }
        // Function that sends the user to the seated exercise tab
        private void seatedExercisesButton_Click(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 2;
        }
        // Function that sends the user to the full body exercise tab
        private void fullBodyExercisesbutton_Click(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 3;
        }
        // Function that sends the user back to the main exercise tab
        private void backToExercisesbutton_Click(object sender, RoutedEventArgs e)
        {
            mainTabControl.SelectedIndex = 0;
        }
        // Re-enables all breathing, seated, and full body exercise buttons
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

        // <--- All functions for the breathing exercise tab and all of its buttons --->
        
        // Function to select deep breathing exercise and re-enable all of the other exercise buttons
        private void deepBreathingButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Deep Breathing";
            reenableExerciseButtons();
            deepBreathingButton.IsEnabled = false;
        }
        // Function to select sitali breathing exercise and re-enable all of the other exercise buttons
        private void sitaliBreathingButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Sitali Breathing";
            reenableExerciseButtons();
            sitaliBreathingButton.IsEnabled = false;
        }

        // <--- All functions for the seated exercise tab and all of its buttons --->

        // <--- All functions for the full body exercise tab and all of its buttons --->

        // <--- All functions for the video tab and all of its buttons --->
        
        // Function that allows the video in the preview window to loop
        private void previewVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            previewVideo.Position = new TimeSpan(0, 0, 1);
            previewVideo.Play();
        }
        // Function to make all video buttons re-enabled on the video tab
        private void reenableVideoButtons()
        {
            wavesVideoButton.IsEnabled = true;
            fireVideoButton.IsEnabled = true;
            cloudsVideoButton.IsEnabled = true;
            caveVideoButton.IsEnabled = true;
            starsVideoButton.IsEnabled = true;
            mountainVideoButton.IsEnabled = true;
            desertVideoButton.IsEnabled = true;
            icebergVideoButton.IsEnabled = true;
            cityVideoButton.IsEnabled = true;
            waterfallVideoButton.IsEnabled = true;
            swampVideoButton.IsEnabled = true;
            flowersVideoButton.IsEnabled = true;
            canyonVideoButton.IsEnabled = true;
            bridgeVideoButton.IsEnabled = true;
            rainforestVideoButton.IsEnabled = true;
        }
        // Function to make all video preview buttons re-enabled on the video tab
        private void reenableVideoPreviewbuttons()
        {
            wavesVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            wavesVideoStatus = 0;
            fireVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            fireVideoStatus = 0;
            cloudsVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            cloudsVideoStatus = 0;
            caveVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            caveVideoStatus = 0;
            starsVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            starsVideoStatus = 0;
            mountainVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            mountainVideoStatus = 0;
            desertVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            desertVideoStatus = 0;
            icebergVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            icebergVideoStatus = 0;
            cityVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            cityVideoStatus = 0;
            waterfallVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            waterfallVideoStatus = 0;
            swampVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            swampVideoStatus = 0;
            flowersVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            flowersVideoStatus = 0;
            canyonVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            canyonVideoStatus = 0;
            bridgeVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            bridgeVideoStatus = 0;
            rainforestVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            rainforestVideoStatus = 0;
        }
        // Function that allows the user to select the wave video
        private void wavesVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Waves";
            reenableVideoButtons();
            wavesVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the waves video in the preview window
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
        // Function that allows the user to select the fire video
        private void fireVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Fire";
            reenableVideoButtons();
            fireVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the fire video in the preview window
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
        // Function that allows the user to select the clouds video
        private void cloudsVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Clouds";
            reenableVideoButtons();
            cloudsVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the clouds video in the preview window
        private void cloudsVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (cloudsVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Clouds Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                cloudsVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                cloudsVideoStatus = 1;
            }
            else if (cloudsVideoStatus == 1)
            {
                previewVideo.Stop();
                cloudsVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                cloudsVideoStatus = 0;
            }
        }
        // Function that allows the user to select the cave video
        private void caveVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Cave";
            reenableVideoButtons();
            caveVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the cave video in the preview window
        private void caveVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (caveVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Cave Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                caveVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                caveVideoStatus = 1;
            }
            else if (caveVideoStatus == 1)
            {
                previewVideo.Stop();
                caveVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                caveVideoStatus = 0;
            }
        }
        // Function that allows the user to select the stars video
        private void starsVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Stars";
            reenableVideoButtons();
            starsVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the stars video in the preview window
        private void starsVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (starsVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Stars Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                starsVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                starsVideoStatus = 1;
            }
            else if (starsVideoStatus == 1)
            {
                previewVideo.Stop();
                starsVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                starsVideoStatus = 0;
            }
        }
        // Function that allows the user to select the mountain video
        private void mountainVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Mountain";
            reenableVideoButtons();
            mountainVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the mountain video in the preview window
        private void mountainVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (mountainVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Mountain Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                mountainVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                mountainVideoStatus = 1;
            }
            else if (mountainVideoStatus == 1)
            {
                previewVideo.Stop();
                mountainVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                mountainVideoStatus = 0;
            }
        }
        // Function that allows the user to select the desert video
        private void desertVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Desert";
            reenableVideoButtons();
            desertVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the desert video in the preview window
        private void desertVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (desertVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Desert Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                desertVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                desertVideoStatus = 1;
            }
            else if (desertVideoStatus == 1)
            {
                previewVideo.Stop();
                desertVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                desertVideoStatus = 0;
            }
        }
        // Function that allows the user to select the iceberg video
        private void icebergVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Iceberg";
            reenableVideoButtons();
            icebergVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the iceberg video in the preview window
        private void icebergVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (icebergVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Iceberg Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                icebergVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                icebergVideoStatus = 1;
            }
            else if (icebergVideoStatus == 1)
            {
                previewVideo.Stop();
                icebergVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                icebergVideoStatus = 0;
            }
        }
        // Function that allows the user to select the city video
        private void cityVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "City";
            reenableVideoButtons();
            cityVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the city video in the preview window
        private void cityVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (cityVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/City Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                cityVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                cityVideoStatus = 1;
            }
            else if (cityVideoStatus == 1)
            {
                previewVideo.Stop();
                cityVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                cityVideoStatus = 0;
            }
        }
        // Function that allows the user to select the waterfall video
        private void waterfallVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Waterfall";
            reenableVideoButtons();
            waterfallVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the waterfall video in the preview window
        private void waterfallVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (waterfallVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Waterfall Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                waterfallVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                waterfallVideoStatus = 1;
            }
            else if (waterfallVideoStatus == 1)
            {
                previewVideo.Stop();
                waterfallVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                waterfallVideoStatus = 0;
            }
        }
        // Function that allows the user to select the swamp video
        private void swampVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Swamp";
            reenableVideoButtons();
            swampVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the swamp video in the preview window
        private void swampVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (swampVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Swamp Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                swampVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                swampVideoStatus = 1;
            }
            else if (swampVideoStatus == 1)
            {
                previewVideo.Stop();
                swampVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                swampVideoStatus = 0;
            }
        }
        // Function that allows the user to select the flowers video
        private void flowersVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Flowers";
            reenableVideoButtons();
            flowersVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the flowers video in the preview window
        private void flowersVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (flowersVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Flowers Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                flowersVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                flowersVideoStatus = 1;
            }
            else if (flowersVideoStatus == 1)
            {
                previewVideo.Stop();
                flowersVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                flowersVideoStatus = 0;
            }
        }
        // Function that allows the user to select the canyon video
        private void canyonVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Canyon";
            reenableVideoButtons();
            canyonVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the canyon video in the preview window
        private void canyonVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (canyonVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Canyon Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                canyonVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                canyonVideoStatus = 1;
            }
            else if (canyonVideoStatus == 1)
            {
                previewVideo.Stop();
                canyonVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                canyonVideoStatus = 0;
            }
        }
        // Function that allows the user to select the bridge video
        private void bridgeVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Bridge";
            reenableVideoButtons();
            bridgeVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the bridge video in the preview window
        private void bridgeVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (bridgeVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Bridge Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                bridgeVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                bridgeVideoStatus = 1;
            }
            else if (bridgeVideoStatus == 1)
            {
                previewVideo.Stop();
                bridgeVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                bridgeVideoStatus = 0;
            }
        }
        // Function that allows the user to select the rainforest video
        private void rainforestVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "Rainforest";
            reenableVideoButtons();
            rainforestVideoButton.IsEnabled = false;
        }
        // Function that plays the preview of the rainforest video in the preview window
        private void rainforestVideoPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (rainforestVideoStatus == 0)
            {
                previewVideo.Source = new Uri("Resources/Video/Rainforest Video.mp4", UriKind.RelativeOrAbsolute);
                previewVideo.Play();
                previewVideo.Volume = 0;
                reenableVideoPreviewbuttons();
                rainforestVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                rainforestVideoStatus = 1;
            }
            else if (rainforestVideoStatus == 1)
            {
                previewVideo.Stop();
                rainforestVideoPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                rainforestVideoStatus = 0;
            }
        }

        // <--- All functions for the audio tab and all of its buttons --->

        // Function to make all audio buttons re-enabled on the video tab
        private void reenableAudioButtons()
        {
            whiteAudioButton.IsEnabled = true;
            pinkAudioButton.IsEnabled = true;
            windAudioButton.IsEnabled = true;
            rainAudioButton.IsEnabled = true;
            birdsAudioButton.IsEnabled = true;
            cricketsAudioButton.IsEnabled = true;
            fireAudioButton.IsEnabled = true;
            frogsAudioButton.IsEnabled = true;
            chimesAudioButton.IsEnabled = true;
            divingAudioButton.IsEnabled = true;
            cityAudioButton.IsEnabled = true;
            oceanAudiobutton.IsEnabled = true;
            thunderAudioButton.IsEnabled = true;
            shopAudioButton.IsEnabled = true;
            leavesAudioButton.IsEnabled = true;
            farmAudioButton.IsEnabled = true;
        }
        // Function to make all audio preview buttons re-enabled on the video tab
        private void reenableAudioPreviewbuttons()
        {
            whiteAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            whiteAudioStatus = 0;
            pinkAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            pinkAudioStatus = 0;
            windAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            windAudioStatus = 0;
            rainAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            rainAudioStatus = 0;
            birdsAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            birdsAudioStatus = 0;
            cricketsAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            cricketsAudioStatus = 0;
            fireAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            fireAudioStatus = 0;
            frogsAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            frogsAudioStatus = 0;
            chimesAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            chimesAudioStatus = 0;
            divingAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            divingAudioStatus = 0;
            cityAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            cityAudioStatus = 0;
            oceanAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            oceanAudioStatus = 0;
            thunderAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            thunderAudioStatus = 0;
            shopAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            shopAudioStatus = 0;
            leavesAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            leavesAudioStatus = 0;
            farmAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
            farmAudioStatus = 0;
        }
        // Function that allows the user to select the white audio
        private void whiteAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "White Noise";
            reenableAudioButtons();
            whiteAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the white audio
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
        // Function that allows the user to select the pink audio
        private void pinkAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Pink Noise";
            reenableAudioButtons();
            pinkAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the pink audio
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
        // Function that allows the user to select the wind audio
        private void windAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Wind";
            reenableAudioButtons();
            windAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the wind audio
        private void windAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (windAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Wind Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                windAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                windAudioStatus = 1;
            }
            else if (windAudioStatus == 1)
            {
                playSound.Stop();
                windAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                windAudioStatus = 0;
            }
        }
        // Function that allows the user to select the rain audio
        private void rainAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Rain";
            reenableAudioButtons();
            rainAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the rain audio
        private void rainAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (rainAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Rain Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                rainAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                rainAudioStatus = 1;
            }
            else if (rainAudioStatus == 1)
            {
                playSound.Stop();
                rainAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                rainAudioStatus = 0;
            }
        }
        // Function that allows the user to select the birds audio
        private void birdsAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Birds";
            reenableAudioButtons();
            birdsAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the birds audio
        private void birdsAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (birdsAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Birds Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                birdsAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                birdsAudioStatus = 1;
            }
            else if (birdsAudioStatus == 1)
            {
                playSound.Stop();
                birdsAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                birdsAudioStatus = 0;
            }
        }
        // Function that allows the user to select the crickets audio
        private void cricketsAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Crickets";
            reenableAudioButtons();
            cricketsAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the crickets audio
        private void cricketsAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (cricketsAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Crickets Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                cricketsAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                cricketsAudioStatus = 1;
            }
            else if (cricketsAudioStatus == 1)
            {
                playSound.Stop();
                cricketsAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                cricketsAudioStatus = 0;
            }
        }
        // Function that allows the user to select the fire audio
        private void fireAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Fire";
            reenableAudioButtons();
            fireAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the fire audio
        private void fireAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (fireAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Fire Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                fireAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                fireAudioStatus = 1;
            }
            else if (fireAudioStatus == 1)
            {
                playSound.Stop();
                fireAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                fireAudioStatus = 0;
            }
        }
        // Function that allows the user to select the frogs audio
        private void frogsAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Frogs";
            reenableAudioButtons();
            frogsAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the frogs audio
        private void frogsAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (frogsAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Frogs Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                frogsAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                frogsAudioStatus = 1;
            }
            else if (frogsAudioStatus == 1)
            {
                playSound.Stop();
                frogsAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                frogsAudioStatus = 0;
            }
        }
        // Function that allows the user to select the chimes audio
        private void chimesAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Chimes";
            reenableAudioButtons();
            chimesAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the chimes audio
        private void chimesAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (chimesAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Chimes Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                chimesAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                chimesAudioStatus = 1;
            }
            else if (chimesAudioStatus == 1)
            {
                playSound.Stop();
                chimesAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                chimesAudioStatus = 0;
            }
        }
        // Function that allows the user to select the diving audio
        private void divingAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Diving";
            reenableAudioButtons();
            divingAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the diving audio
        private void divingAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (divingAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Diving Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                divingAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                divingAudioStatus = 1;
            }
            else if (divingAudioStatus == 1)
            {
                playSound.Stop();
                divingAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                divingAudioStatus = 0;
            }
        }
        // Function that allows the user to select the city audio
        private void cityAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "City";
            reenableAudioButtons();
            cityAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the city audio
        private void cityAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            if (cityAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\City Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                cityAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                cityAudioStatus = 1;
            }
            else if (cityAudioStatus == 1)
            {
                playSound.Stop();
                cityAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                cityAudioStatus = 0;
            }
        }
        // Function that allows the user to select the ocean audio
        private void oceanAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Ocean";
            reenableAudioButtons();
            oceanAudiobutton.IsEnabled = false;
        }
        // Function that plays the preview of the ocean audio
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
        // Function that allows the user to select the thunder audio
        private void thunderAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Thunder";
            reenableAudioButtons();
            thunderAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the thunder audio
        private void thunderAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer();
            if (thunderAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Thunder Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                thunderAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                thunderAudioStatus = 1;
            }
            else if (thunderAudioStatus == 1)
            {
                playSound.Stop();
                thunderAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                thunderAudioStatus = 0;
            }
        }
        // Function that allows the user to select the shop audio
        private void shopAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Shop";
            reenableAudioButtons();
            shopAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the shop audio
        private void shopAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer();
            if (shopAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Shop Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                shopAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                shopAudioStatus = 1;
            }
            else if (shopAudioStatus == 1)
            {
                playSound.Stop();
                shopAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                shopAudioStatus = 0;
            }
        }
        // Function that allows the user to select the leaves audio
        private void leavesAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Leaves";
            reenableAudioButtons();
            leavesAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the leaves audio
        private void leavesAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer();
            if (leavesAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Leaves Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                leavesAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                leavesAudioStatus = 1;
            }
            else if (leavesAudioStatus == 1)
            {
                playSound.Stop();
                leavesAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                leavesAudioStatus = 0;
            }
        }
        // Function that allows the user to select the farm audio
        private void farmAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "Farm";
            reenableAudioButtons();
            farmAudioButton.IsEnabled = false;
        }
        // Function that plays the preview of the farm audio
        private void farmAudioPreviewbutton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer();
            if (farmAudioStatus == 0)
            {
                playSound.SoundLocation = @"Resources\Audio\Farm Audio.wav";
                playSound.Load();
                playSound.PlayLooping();
                reenableAudioPreviewbuttons();
                farmAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Stop Media Button.png", UriKind.RelativeOrAbsolute));
                farmAudioStatus = 1;
            }
            else if (farmAudioStatus == 1)
            {
                playSound.Stop();
                farmAudioPreviewimage.Source = new BitmapImage(new Uri("Resources/Images & Icons/Play Media Button.png", UriKind.RelativeOrAbsolute));
                farmAudioStatus = 0;
            }
        }

        // <--- All functions for the start tab and all of its buttons --->

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
                switch (videoSelectedTextblock.Text)
                {
                    case "Waves":
                        playVideo.Source = new Uri("Resources/Video/Waves Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Fire":
                        playVideo.Source = new Uri("Resources/Video/Fire Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Clouds":
                        playVideo.Source = new Uri("Resources/Video/Clouds Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Cave":
                        playVideo.Source = new Uri("Resources/Video/Cave Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Stars":
                        playVideo.Source = new Uri("Resources/Video/Stars Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Mountain":
                        playVideo.Source = new Uri("Resources/Video/Mountain Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Desert":
                        playVideo.Source = new Uri("Resources/Video/Desert Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Iceberg":
                        playVideo.Source = new Uri("Resources/Video/Iceberg Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "City":
                        playVideo.Source = new Uri("Resources/Video/City Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Waterfall":
                        playVideo.Source = new Uri("Resources/Video/Waterfall Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Swamp":
                        playVideo.Source = new Uri("Resources/Video/Swamp Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Flowers":
                        playVideo.Source = new Uri("Resources/Video/Flowers Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Canyon":
                        playVideo.Source = new Uri("Resources/Video/Canyon Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Bridge":
                        playVideo.Source = new Uri("Resources/Video/Bridge Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    case "Rainforest":
                        playVideo.Source = new Uri("Resources/Video/Rainforest Video.mp4", UriKind.RelativeOrAbsolute);
                        playVideo.Play();
                        reenableVideoPreviewbuttons();
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }
            // Audio selection logic
            if (audioSelectedTextblock.Text != "None")
            {
                switch (audioSelectedTextblock.Text) 
                {
                    case "White Noise":
                        playSound.SoundLocation = @"Resources\Audio\White Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Pink Noise":
                        playSound.SoundLocation = @"Resources\Audio\Pink Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Wind":
                        playSound.SoundLocation = @"Resources\Audio\Wind Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Rain":
                        playSound.SoundLocation = @"Resources\Audio\Rain Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Birds":
                        playSound.SoundLocation = @"Resources\Audio\Birds Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Crickets":
                        playSound.SoundLocation = @"Resources\Audio\Crickets Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Fire":
                        playSound.SoundLocation = @"Resources\Audio\Fire Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Frogs":
                        playSound.SoundLocation = @"Resources\Audio\Frogs Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Chimes":
                        playSound.SoundLocation = @"Resources\Audio\Chimes Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Diving":
                        playSound.SoundLocation = @"Resources\Audio\Diving Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "City":
                        playSound.SoundLocation = @"Resources\Audio\City Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Ocean":
                        playSound.SoundLocation = @"Resources\Audio\Ocean Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Thunder":
                        playSound.SoundLocation = @"Resources\Audio\Thunder Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Shop":
                        playSound.SoundLocation = @"Resources\Audio\Shop Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Leaves":
                        playSound.SoundLocation = @"Resources\Audio\Leaves Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    case "Farm":
                        playSound.SoundLocation = @"Resources\Audio\Farm Audio.wav";
                        playSound.Load();
                        playSound.PlayLooping();
                        reenableAudioPreviewbuttons();
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }
            // Exercise selection logic
            if (exerciseSelectedTextblock.Text != "None")
            {
                switch (exerciseSelectedTextblock.Text) 
                {
                    case "Deep Breathing":
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
                        break;
                    case "Sitali Breathing":
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
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
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
