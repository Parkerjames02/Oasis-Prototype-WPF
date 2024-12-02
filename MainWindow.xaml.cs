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
using System.Threading;

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

        // Creates a private cancellation token for the exercises
        private CancellationTokenSource _cancellationTokenSource;

        // Creates a integer variable to loop the exercise
        int exerciseStatus = 0;

        // Creates a integer variable for the selected exercise tab
        int selectedExerciseTab = 0;

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
            exerciseTab.Visibility = Visibility.Collapsed;
            breathingExerciseTab.Visibility = Visibility.Visible;
            mainTabControl.SelectedIndex = 1;
            selectedExerciseTab = 1;
        }
        // Function that sends the user to the seated exercise tab
        private void seatedExercisesButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseTab.Visibility = Visibility.Collapsed;
            seatedExerciseTab.Visibility = Visibility.Visible;
            mainTabControl.SelectedIndex = 2;
            selectedExerciseTab = 2;
        }
        // Function that sends the user to the full body exercise tab
        private void fullBodyExercisesbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseTab.Visibility = Visibility.Collapsed;
            fullBodyExercisetab.Visibility = Visibility.Visible;
            mainTabControl.SelectedIndex = 3;
            selectedExerciseTab = 3;
        }
        // Function that sends the user back to the main exercise tab
        private void backToExercisesbutton_Click(object sender, RoutedEventArgs e)
        {
            breathingExerciseTab.Visibility = Visibility.Collapsed;
            seatedExerciseTab.Visibility = Visibility.Collapsed;
            fullBodyExercisetab.Visibility = Visibility.Collapsed;
            exerciseTab.Visibility = Visibility.Visible;
            mainTabControl.SelectedIndex = 0;
            selectedExerciseTab = 0;
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
            pursedLipBreathingbutton.IsEnabled = true;
            resonantBreathingButton.IsEnabled = true;
            seatedSpinalTwistbutton.IsEnabled = true;
            tricepsStretchesButton.IsEnabled = true;
            shoulderPectoralStretchbutton.IsEnabled = true;
            hipKneeStretchbutton.IsEnabled = true;
            shoulderPectoralStretchbutton.IsEnabled = true;
            hipKneeStretchbutton.IsEnabled = true;
            shoulderShrugButton.IsEnabled = true;
            neckStretchesButton.IsEnabled = true;
            seatedLeanBacksbutton.IsEnabled = true;
            seatedHipStretchbutton.IsEnabled = true;
            childsPoseButton.IsEnabled = true;
            catCowButton.IsEnabled = true;
            puppyPoseButton.IsEnabled = true;
            lungingHipFlexorbutton.IsEnabled = true;
            downwardFacingDogbutton.IsEnabled = true;
            forwardFoldButton.IsEnabled = true;
            pigeonPoseButton.IsEnabled = true;
            lowerTrunkRotationbutton.IsEnabled = true;
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
        // Function to select modified lions breath exercise and re-enable all of the other exercise buttons
        private void modifiedLionsBreathbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Modified Lions Breath";
            reenableExerciseButtons();
            modifiedLionsBreathbutton.IsEnabled = false;
        }
        // Function to select humming bee breathing exercise and re-enable all of the other exercise buttons
        private void hummingBeeBreathingbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Humming Bee Breathing";
            reenableExerciseButtons();
            hummingBeeBreathingbutton.IsEnabled = false;
        }
        // Function to select equal time breathing exercise and re-enable all of the other exercise buttons
        private void equalTimeBreathingbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Equal Time Breathing";
            reenableExerciseButtons();
            equalTimeBreathingbutton.IsEnabled = false;
        }
        // Function to select alternate nostril breathing exercise and re-enable all of the other exercise buttons
        private void alternateNostrilBreathingbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Alternate Nostril Breathing";
            reenableExerciseButtons();
            alternateNostrilBreathingbutton.IsEnabled = false;
        }
        // Function to select pursed lip breathing exercise and re-enable all of the other exercise buttons
        private void pursedLipBreathingbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Pursed Lip Breathing";
            reenableExerciseButtons();
            pursedLipBreathingbutton.IsEnabled = false;
        }
        // Function to select resonant breathing exercise and re-enable all of the other exercise buttons
        private void resonantBreathingButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Resonant Breathing";
            reenableExerciseButtons();
            resonantBreathingButton.IsEnabled = false;
        }

        // <--- All functions for the seated exercise tab and all of its buttons --->

        // Function to select seated spinal twist exercise and re-enable all of the other exercise buttons
        private void seatedSpinalTwistbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Seated Spinal Twist";
            reenableExerciseButtons();
            seatedSpinalTwistbutton.IsEnabled = false;
        }
        // Function to select triceps stretches exercise and re-enable all of the other exercise buttons
        private void tricepsStretchesButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Triceps Stretches";
            reenableExerciseButtons();
            tricepsStretchesButton.IsEnabled = false;
        }
        // Function to select shoulder and pectoral stretch exercise and re-enable all of the other exercise buttons
        private void shoulderPectoralStretchbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Shoulder & Pectoral Stretch";
            reenableExerciseButtons();
            shoulderPectoralStretchbutton.IsEnabled = false;
        }
        // Function to select hip and knee flexion stretch exercise and re-enable all of the other exercise buttons
        private void hipKneeStretchbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Hip & Knee Flexion Stretch";
            reenableExerciseButtons();
            hipKneeStretchbutton.IsEnabled = false;
        }
        // Function to select shoulder shrug exercise and re-enable all of the other exercise buttons
        private void shoulderShrugButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Shoulder Shrug";
            reenableExerciseButtons();
            shoulderShrugButton.IsEnabled = false;
        }
        // Function to select neck stretches exercise and re-enable all of the other exercise buttons
        private void neckStretchesButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Neck Stretches";
            reenableExerciseButtons();
            neckStretchesButton.IsEnabled = false;
        }
        // Function to select seated lean backs exercise and re-enable all of the other exercise buttons
        private void seatedLeanBacksbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Seated Lean Backs";
            reenableExerciseButtons();
            seatedLeanBacksbutton.IsEnabled = false;
        }
        // Function to select seated lean backs exercise and re-enable all of the other exercise buttons
        private void seatedHipStretchbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Seated Hip Stretch";
            reenableExerciseButtons();
            seatedHipStretchbutton.IsEnabled = false;
        }

        // <--- All functions for the full body exercise tab and all of its buttons --->

        // Function to select child's pose exercise and re-enable all of the other exercise buttons
        private void childsPoseButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Child's Pose";
            reenableExerciseButtons();
            childsPoseButton.IsEnabled = false;
        }
        // Function to select cat-cow exercise and re-enable all of the other exercise buttons
        private void catCowButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Cat-Cow";
            reenableExerciseButtons();
            catCowButton.IsEnabled = false;
        }
        // Function to select puppy pose exercise and re-enable all of the other exercise buttons
        private void puppyPoseButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Puppy Pose";
            reenableExerciseButtons();
            puppyPoseButton.IsEnabled = false;
        }
        // Function to select lunging hip-flexor stretch exercise and re-enable all of the other exercise buttons
        private void lungingHipFlexorbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Lunging Hip-Flexor Stretch";
            reenableExerciseButtons();
            lungingHipFlexorbutton.IsEnabled = false;
        }
        // Function to select downward facing dog exercise and re-enable all of the other exercise buttons
        private void downwardFacingDogbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Downward Facing Dog";
            reenableExerciseButtons();
            downwardFacingDogbutton.IsEnabled = false;
        }
        // Function to select forward fold exercise and re-enable all of the other exercise buttons
        private void forwardFoldButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Forward Fold";
            reenableExerciseButtons();
            forwardFoldButton.IsEnabled = false;
        }
        // Function to select pigeon pose exercise and re-enable all of the other exercise buttons
        private void pigeonPoseButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Pigeon Pose";
            reenableExerciseButtons();
            pigeonPoseButton.IsEnabled = false;
        }
        // Function to select lower trunk rotation exercise and re-enable all of the other exercise buttons
        private void lowerTrunkRotationbutton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "Lower Trunk Rotation";
            reenableExerciseButtons();
            lowerTrunkRotationbutton.IsEnabled = false;
        }

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

        // Function that resets the selected exercise to none
        private void resetExerciseButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelectedTextblock.Text = "None";
            reenableExerciseButtons();
            exerciseStatus = 0;
        }
        // Function that resets the selected video to none
        private void resetVideoButton_Click(object sender, RoutedEventArgs e)
        {
            videoSelectedTextblock.Text = "None";
            reenableVideoButtons();
            reenableVideoPreviewbuttons();
            previewVideo.Stop();
        }
        // Function that resets the selected audio to none
        private void resetAudioButton_Click(object sender, RoutedEventArgs e)
        {
            audioSelectedTextblock.Text = "None";
            reenableAudioButtons();
            reenableAudioPreviewbuttons();
            playSound.Stop();
        }
        // Function that allows the video in the custom experience tab to loop
        private void playVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            playVideo.Position = new TimeSpan(0, 0, 1);
            playVideo.Play();
        }
        // Function that contains the conditional statement that dictates what video is played on the custom experience tab
        private void startVideo()
        {
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
                }
            }
        }
        // Function that contains the conditional statement that dictates what audio is played on the custom experience tab
        private void startAudio()
        {
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
                }
            }
        }
        // Function that contains the conditional statement that dictates what exercise guide is shown on the custom experience tab
        private async Task startExercise(CancellationToken token)
        {
            for (int i = 0; i < 10; i++)
            {
                token.ThrowIfCancellationRequested();
            }
            try
            {
                if (exerciseSelectedTextblock.Text != "None")
                {
                    switch (exerciseSelectedTextblock.Text)
                    {
                        // <--- All cases for breathing exercises --->
                        case "Deep Breathing":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your deep breathing exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Take a deep inhale through your nose for 4 seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now exhale through your mouth for 6 seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Take a deep inhale through your nose for 4 seconds";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now exhale through your mouth for 6 seconds";
                            }
                            break;
                        case "Sitali Breathing":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your sitali breathing exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Put your tongue against your bottom row of teeth";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now slightly purse your lips and inhale until your lungs are full";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now close your mouth and fully exhale through your nose";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Put your tongue against your bottom row of teeth";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now slightly purse your lips and inhale until your lungs are full";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now close your mouth and fully exhale through your nose";
                            }
                            break;
                        case "Modified Lions Breath":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your modified lions breath exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Breathe in through your nose until your belly is full of air";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now open your mouth as much as you can and breathe out";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Try to make a 'HA' sound while exhaling";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Breathe in through your nose until your belly is full of air";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now open your mouth as much as you can and breathe out";
                            }
                            break;
                        case "Humming Bee Breathing":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your humming bee breathing exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Inhale slowly and deeply through your nose";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Make sure that your mouth is closed with your lips pressed together";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now exhale through your nose while making a 'hmmm' sound like a bee";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Focus on the vibration of the buzz to calm yourself";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Inhale slowly and deeply through your nose";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now exhale through your nose while making a 'hmmm' sound like a bee";
                            }
                            break;
                        case "Equal Time Breathing":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your equal time breathing exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Breathe in through your nose for five seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now breathe out through your nose for five seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Breathe in through your nose for five seconds";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now breathe out through your nose for five seconds";
                            }
                            break;
                        case "Alternate Nostril Breathing":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your alternate nostril breathing exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Breathe in through your nose for five seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now breathe out through your nose for five seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Breathe in through your nose for five seconds";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now breathe out through your nose for five seconds";
                            }
                            break;
                        case "Pursed Lip Breathing":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your pursed lip breathing exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Breathe in through your nose for two seconds while your mouth is closed";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Purse your lips as if you are going to whistle or blow a candle";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Breathe out slowly through your lips for four seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Breathe in through your nose for two seconds while your mouth is closed";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Purse your lips as if you are going to whistle or blow a candle";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Breathe out slowly through your lips for four seconds";
                            }
                            break;
                        case "Resonant Breathing":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your resonant breathing exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Take a deep breath for five seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Hold your breath for five seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now breath out for five seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Take a deep breath for five seconds";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Hold your breath for five seconds";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now breath out for five seconds";
                            }
                            break;
                        // <--- All cases for seated exercises --->
                        case "Seated Spinal Twist":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your seated spinal twist exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Sit towards the edge of your chair with your feet flat on the floor";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Place your right hand on the back of your seat";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now place your left hand on your right thigh";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Inhale, lengthen your spine, then exhale and rotate your torso to the right";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "You should now be looking over your right shoulder";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "After that can repeat these same steps on the opposite side";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Sit towards the edge of your chair with your feet flat on the floor";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Place your left hand on the back of your seat";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now place your right hand on your left thigh";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Inhale, lengthen your spine, then exhale and rotate your torso to the left";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "You should now be looking over your left shoulder";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Nice, lets try doing these same steps on the opposite side now";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Sit towards the edge of your chair with your feet flat on the floor";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Place your right hand on the back of your seat";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now place your left hand on your right thigh";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Inhale, lengthen your spine, then exhale and rotate your torso to the right";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "You should now be looking over your right shoulder";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now we go back to the other side";
                            }
                            break;
                        case "Triceps Stretches":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your triceps stretches exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Raise your arm and bend it so that your elbow is sticking up";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Your hand should now be behind your neck";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now take your other hand and place it on your elbow";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Use that hand to pull your elbow towards your head";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Hold this pose for thirty seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "After that can repeat these same steps on the opposite side";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Raise your arm and bend it so that your elbow is sticking up";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Your hand should now be behind your neck";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now take your other hand and place it on your elbow";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Use that hand to pull your elbow towards your head";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Hold this pose for thirty seconds";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Awesome, lets now do the same thing on the opposite side";
                            }
                            break;
                        case "Shoulder & Pectoral Stretch":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your shoulder & pectoral stretch exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Start off this exercise by sitting on the front edge of the chair";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Put your hands behind your back and interlock your fingers";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now push your chest outward and raise your chin";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Hold this pose for thirty seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Sit on the front edge of your chair";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Put your hands behind your back and interlock your fingers";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now push your chest outward and raise your chin";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Hold this pose for thirty seconds";
                            }
                            break;
                        case "Hip & Knee Flexion Stretch":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your hip & flexion stretch exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Start by putting your back against the back of your seat";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Also make sure that you lay both of your feet flat in front of you";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now put both hands on one of your knees and pull it up to your chest";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Hold this pose for thirty seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "You can now do the exact same thing with the opposite knee";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Put your back against the back of your seat";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Also make sure that you lay both feet flat in front of you";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now put both hands on one of your knees and pull it up to your chest";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Hold this pose for thirty seconds";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now do the exact same thing with the opposite knee";
                            }
                            break;
                        case "Shoulder Shrug":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your shoulder shrug exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "This exercise is very simple";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "All you have to do is raise both of your shoulders towards your ear";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Drop them and repeat ten times or until you feel properly stretched";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "All you have to do is raise both of your shoulders towards your ear";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Drop them and repeat ten times or until you feel properly stretched";
                            }
                            break;
                        case "Neck Stretches":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your neck stretches exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Start this exercise by relaxing your neck and leaning your head forward";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Slowly roll your head to one side and hold for ten seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now slowly roll your head to the opposite side and hold for ten seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Relax you head once more, returning your head to the forward position";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Repeat these same steps three times or as many time as you want";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Relax your neck and lean your head forward";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Slowly roll your head to one side and hold for ten seconds";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now slowly roll your head to the opposite side and hold for ten seconds";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Relax you head once more, returning your head to the forward position";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Repeat these same steps three times or as many time as you want";
                            }
                            break;
                        case "Seated Lean Backs":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your seated lean backs exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Sit in the middle of the chair with your spine straight and tall";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Make sure to also have your feet planted on the ground";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Cross your arms over your chest with your palms on each shoulder";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now lean your upper back toward the back of the chair";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Make sure that your back is kept straight during this movement";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "When your back touches the back rest slowly return to sitting upright";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Feel free to repeat this exercise as many times as you want";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Sit in the middle of the chair with your spine straight and tall";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Make sure to also have your feet planted on the ground";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Cross your arms over your chest with your palms on each shoulder";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now lean your upper back toward the back of the chair";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Make sure that your back is kept straight during this movement";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "When your back touches the back rest slowly return to sitting upright";
                            }
                            break;
                        case "Seated Hip Stretch":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your seated hip stretch exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Start by sitting straight in your chair with your left foot on the ground";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now take your right foot and cross it over your left knee";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Keep your back straight and lean forward until you feel the stretch";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Hold this pose for thirty seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now repeat these same steps but on the opposite side";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Sit up straight in your chair with your left foot on the ground";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now take your right foot and cross it over your left knee";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Keep your back straight and lean forward until you feel the stretch";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Hold this pose for thirty seconds";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now repeat these same steps but on the opposite side";
                            }
                            break;
                        // <--- All cases for full body exercises --->
                        case "Child's Pose":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your child's pose exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Start by kneeling down with your knees apart and feet behind you";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Take a deep inhale and then exhale while lowering your torso to your thighs";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Make sure that your arms are forward and that your butt is touching your feet";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Lengthen your neck and spine by drawing your ribs away from your tailbone";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "With your forehead on the floor you should feel a stretch in your hips";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Try and hold this pose for sixty seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Start by kneeling down with your knees apart and feet behind you";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Take a deep inhale and then exhale while lowering your torso to your thighs";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Make sure that your arms are forward and that your butt is touching your feet";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Lengthen your neck and spine by drawing your ribs away from your tailbone";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "With your forehead on the floor you should feel a stretch in your hips";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Try and hold this pose for sixty seconds";
                            }
                            break;
                        case "Cat-Cow":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your cat-cow exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Go on all fours with your shoulders over your wrists and hips over your knees";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Take a slow inhale and round your spine and drop your head while exhaling";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now inhale and lift your head, chest, and tailbone toward the ceiling";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "You should feel a stretch in your spine and possibly your glutes and shoulders";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Continue performing this movement for sixty seconds or more";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Go on all fours with your shoulders over your wrists and hips over your knees";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Take a slow inhale and round your spine and drop your head while exhaling";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now inhale and lift your head, chest, and tailbone toward the ceiling";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "You should feel a stretch in your spine and possibly your glutes and shoulders";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Continue performing this movement for sixty seconds or more";
                            }
                            break;
                        case "Puppy Pose":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your puppy pose exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Go on all fours with your shoulders over your wrists and hips over your knees";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now walk your arms forward and bring your chin to the floor";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Try to do this by while keeping your butt lifted above your knees";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Your arms should be stretched in front of you and your armpits above the floor";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "You should feel a stretch in your armpits and chest";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Go on all fours with your shoulders over your wrists and hips over your knees";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now walk your arms forward and bring your chin to the floor";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Try to do this by while keeping your butt lifted above your knees";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Your arms should be stretched in front of you and your armpits above the floor";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "You should feel a stretch in your armpits and chest";
                            }
                            break;
                        case "Lunging Hip-Flexor Stretch":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your lunging hip-flexor stretch exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Kneel on one knee and place your opposite foot flat in front of you";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "For a deeper stretch lean forward, stretching your hip towards the floor";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Squeeze the muscles in your butt to stretch your hip flexor even more";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Try and hold this pose for sixty seconds and then switch sides and repeat";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Kneel on one knee and place your opposite foot flat in front of you";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "For a deeper stretch lean forward, stretching your hip towards the floor";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Squeeze the muscles in your bitt to stretch your hip flexor even more";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Try and hold this pose for sixty seconds and then switch sides and repeat";
                            }
                            break;
                        case "Downward Facing Dog":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your downward facing dog exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Start on your hands and knees with your hands stacked under your shoulders";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Spread your hands wide and press your index finger and thumb into the floor";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Lift your tailbone and press your butt up and back, pushing your hips up";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Straighten your legs as best as you can and press your heels to the floor";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Make sure that your head is relaxed and that your back is flat";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "You should feel a stretch in your hamstrings, calves, back, and shoulders";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Hold this pose for at least sixty seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Start on your hands and knees with your hands stacked under your shoulders";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Spread your hands wide and press your index finger and thumb into the floor";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Lift your tailbone and press your butt up and back, pushing your hips up";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Straighten your legs as best as you can and press your heels to the floor";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Make sure that your head is relaxed and that your back is flat";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "You should feel a stretch in your hamstrings, calves, back, and shoulders";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Hold this pose for at least sixty seconds";
                            }
                            break;
                        case "Forward Fold":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your forward fold exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Stand with your feet shoulder-width apart";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Stretch your legs without locking your knees and bend your torso down";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Tuck your chin in toward your chest and relax your shoulders";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Try to push the top of your head towards the floor to stretch your spine";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "You should feel a stretch in your back and hamstrings";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Hold this pose for at least sixty seconds";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Stand with your feet shoulder-width apart";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Stretch your legs without locking your knees and bend your torso down";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Tuck your chin in toward your chest and relax your shoulders";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Try to push the top of your head towards the floor to stretch your spine";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "You should feel a stretch in your back and hamstrings";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Hold this pose for at least sixty seconds";
                            }
                            break;
                        case "Pigeon Pose":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your pigeon pose exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "From a kneeling position bend your right foot towards your left knee";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now take your left leg on lay it out flat on the floor behind you";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Your right foot should be on the floor and close to the left side of your hips";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Try to keep your right foot flexed and push your left hip towards the floor";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "You should feel a stretch in your right hip";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Hold this pose for sixty seconds and then switch sides and repeat";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "From a kneeling position bend your right foot towards your left knee";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now take your left leg on lay it out flat on the floor behind you";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Your right foot should be on the floor and close to the left side of your hips";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Try to keep your right foot flexed and push your left hip towards the floor";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "You should feel a stretch in your right hip";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Hold this pose for sixty seconds and then switch sides and repeat";
                            }
                            break;
                        case "Lower Trunk Rotation":
                            await Task.Delay(3000, token);
                            exerciseInsturctionsBackground.Visibility = Visibility.Visible;
                            exerciseInsturctionsText.Text = "Your lower trunk rotation exercise will begin now...";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Begin by lying on your back with your knees bent and arms by your side";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Now slowly allow your knees to drift all the way to your right side";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Try to keep your knees glued together as you make this movement";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "You should feel a stretch and twist in your lower back area";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "After a few seconds, pick up your knees and allow them to fall to the left side";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Continue to rock side to side, allowing a few seconds of stretch on each side";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Try to repeat this movement for five twists on each side";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "Nice, those are all of the steps to this exercise";
                            await Task.Delay(6000, token);
                            exerciseInsturctionsText.Text = "The steps of the exercise will now continuously repeat";
                            while (exerciseStatus == 1)
                            {
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Begin by lying on your back with your knees bent and arms by your side";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Now slowly allow your knees to drift all the way to your right side";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Try to keep your knees glued together as you make this movement";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "You should feel a stretch and twist in your lower back area";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "After a few seconds, pick up your knees and allow them to fall to the left side";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Continue to rock side to side, allowing a few seconds of stretch on each side";
                                await Task.Delay(6000, token);
                                exerciseInsturctionsText.Text = "Try to repeat this movement for five twists on each side";
                            }
                            break;
                    }
                }
            }
            catch (OperationCanceledException)
            {
                
            }
        }
        
        // Function that launches the entire custom stress relief experience
        private async void startButton_Click(object sender, RoutedEventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;
            exerciseStatus = 1;
            exerciseInsturctionsBackground.Visibility = Visibility.Collapsed;
            exerciseInsturctionsText.Text = "";
            previewVideo.Stop();
            playSound.Stop();
            reenableVideoPreviewbuttons();
            reenableAudioPreviewbuttons();
            mainTabControl.SelectedIndex = 7;
            exerciseTab.Visibility = Visibility.Collapsed;
            breathingExerciseTab.Visibility = Visibility.Collapsed;
            seatedExerciseTab.Visibility = Visibility.Collapsed;
            fullBodyExercisetab.Visibility = Visibility.Collapsed;
            videoTab.Visibility = Visibility.Collapsed;
            audioTab.Visibility = Visibility.Collapsed;
            startTab.Visibility = Visibility.Collapsed;
            // Calls function that plays video on the custom experience tab
            startVideo();
            // Calls function that plays audio on the custom experience tab
            startAudio();
            // Calls function that shows the exercise guide on the custom experience tab
            try
            {
                await startExercise(token);
            }
            catch (OperationCanceledException)
            {
                
            }
        }

        // <--- All functions for the custom stress free experience tab and all of its buttons --->

        // Function that closes the custom experience tab and sends the user back to the start tab
        private void backToMainbutton_Click(object sender, RoutedEventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            exerciseInsturctionsText.Text = "";
            exerciseInsturctionsBackground.Visibility = Visibility.Collapsed;
            playSound.Stop();
            playVideo.Stop();
            switch (selectedExerciseTab)
            {
                case 0:
                    exerciseTab.Visibility = Visibility.Visible;
                    break;
                case 1:
                    breathingExerciseTab.Visibility = Visibility.Visible;
                    break;
                case 2:
                    seatedExerciseTab.Visibility = Visibility.Visible;
                    break;
                case 3:
                    fullBodyExercisetab.Visibility = Visibility.Visible;
                    break;
            }
            videoTab.Visibility = Visibility.Visible;
            audioTab.Visibility = Visibility.Visible;
            startTab.Visibility = Visibility.Visible;
            mainTabControl.SelectedIndex = 6;
        }
    }
}
