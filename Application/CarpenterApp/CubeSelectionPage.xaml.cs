using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CarpenterApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CubeSelectionPage : Page
    {
        public CubeSelectionPage()
        {
            this.InitializeComponent();
            welcomeUser();
        }

        private void welcomeUser()
        {
            var a = DateTime.Now.Hour;

            if (a < 10)
                greetings.Text = "Good Morning User";
            else if (a < 12)
                greetings.Text = "Good Noon User";
            else if (a < 13)
                greetings.Text = "Good Afternoon User";
            else if (a < 18)
                greetings.Text = "Good Evening User";
            else
                greetings.Text = "Good Night User";
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void Type1click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InputPage), "c1");
        }

        private void Type2click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InputPage), "c2");
        }

        private void Type3click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InputPage), "c3");
        }

        private void type4click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InputPage), "c4");
        }
    }
}
