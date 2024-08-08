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

namespace Oasis_Prototype__WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void breathingExercisesbtn_Click(object sender, RoutedEventArgs e)
        {
            exerciseSelected.Text = "It Worked!";
        }

        private void wavesVideobtn_Click(object sender, RoutedEventArgs e)
        {
            videoSelected.Text = "It Worked! x2";
            wavesVideobtn.IsEnabled = false;
        }

        private void whiteAudiobtn_Clicked(object sender, RoutedEventArgs e)
        {
            audioSelected.Text = "It Worked! x3";
            whiteAudiobtn.IsEnabled = false;
        }
    }
}
