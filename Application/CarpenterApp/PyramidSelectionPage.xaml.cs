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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CarpenterApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PyramidSelectionPage : Page
    {
        public PyramidSelectionPage()
        {
            this.InitializeComponent();
            welcomeUser();
        }

        private void welcomeUser()
        {
            var a = DateTime.Now.Hour;

            if (a < 10)
                greeting.Text = "Good Morning User";
            else if (a < 12)
                greeting.Text = "Good Noon User";
            else if (a < 13)
                greeting.Text = "Good Afternoon User";
            else if (a < 18)
                greeting.Text = "Good Evening User";
            else
                greeting.Text = "Good Night User";
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameter = e.Parameter as string;
            para = parameter;
            if (parameter.Equals("a"))
            {
                ImageBrush brush1 = new ImageBrush();
                brush1.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/tri-pyramid.JPG"));
                button.Background = brush1;
                button1.Background = brush1;
            }
            else
            {
                ImageBrush brush1 = new ImageBrush();
                brush1.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/cube-pyramid.JPG"));
                button.Background = brush1;
                button1.Background = brush1;
            }
        }
        private String para;
        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void Type1Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InputPage), para+"1");
        }

        private void Type2Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InputPage), para + "2");
        }
    }
}
