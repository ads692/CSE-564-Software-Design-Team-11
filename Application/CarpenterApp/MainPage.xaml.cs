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
    public sealed partial class MainPage : Page
    {
        public MainPage()
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
            else if(a < 13)
                greeting.Text = "Good Afternoon User";
            else if (a < 18)
                greeting.Text = "Good Evening User";
            else
                greeting.Text = "Good Night User";
        }

        private void OnCubeClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CubeSelectionPage));
        }

        private void TriangularPyramidClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PyramidSelectionPage),"a");
        }

        private void CubePyramidClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PyramidSelectionPage), "b");
        }
    }
}
