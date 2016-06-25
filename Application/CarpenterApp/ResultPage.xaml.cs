using CarpenterApp.ViewModel;
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
    public sealed partial class ResultPage : Page
    {
        public ResultPage()
        {
            this.InitializeComponent();
        }
        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        String parameter;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            parameter = e.Parameter as string;
            CategoryDisplay();
        }

        Calculation calculationObject = new Calculation();

        private void CategoryDisplay()
        {
            if (parameter.Equals("c1"))
            {
                //plank1.Source = new BitmapImage(new Uri("ms-appx:/Assets/plank.JPG"));
                plank1.Visibility = Visibility.Visible;
                lengthimage.Visibility = Visibility.Visible;
                answer1.Visibility = Visibility.Visible;
                pieces11.Visibility = Visibility.Visible;

                answer1.Text = calculationObject.cube1_side_length(CalculationData.length).ToString() + " " + CalculationData.unit;
            }
            if (parameter.Equals("c2"))
            {
                //plank1.Source = new BitmapImage(new Uri("ms-appx:/Assets/plank.JPG"));
                plank1.Visibility = Visibility.Visible;
                lengthimage.Visibility = Visibility.Visible;
                answer1.Visibility = Visibility.Visible;
                pieces1.Visibility = Visibility.Visible;

                //plank2.Source = new BitmapImage(new Uri("ms-appx:/Assets/plank.JPG"));
                plank2.Visibility = Visibility.Visible;
                lengthimage1.Visibility = Visibility.Visible;
                answer2.Visibility = Visibility.Visible;
                pieces2.Visibility = Visibility.Visible;

                //plank3.Source = new BitmapImage(new Uri("ms-appx:/Assets/plank.JPG"));
                plank3.Visibility = Visibility.Visible;
                lengthimage2.Visibility = Visibility.Visible;
                answer3.Visibility = Visibility.Visible;
                pieces3.Visibility = Visibility.Visible;

                var ans = calculationObject.cube2_side_length(CalculationData.length, CalculationData.width, CalculationData.breadth);


                answer1.Text = ans[0].ToString() + " " + CalculationData.unit;
                answer2.Text = ans[1].ToString() + " " + CalculationData.unit;
                answer3.Text = ans[2].ToString() + " " + CalculationData.unit;
            }
            if (parameter.Equals("c3"))
            {
            //    plank1.Source = new BitmapImage(new Uri("ms-appx:/Assets/plank.JPG"));
                plank1.Visibility = Visibility.Visible;
                lengthimage.Visibility = Visibility.Visible;
                answer1.Visibility = Visibility.Visible;
                pieces1.Visibility = Visibility.Visible;

                //plank2.Source = new BitmapImage(new Uri("ms-appx:/Assets/plank.JPG"));
                plank2.Visibility = Visibility.Visible;
                lengthimage1.Visibility = Visibility.Visible;
                answer2.Visibility = Visibility.Visible;
                pieces2.Visibility = Visibility.Visible;

                //plank3.Source = new BitmapImage(new Uri("ms-appx:/Assets/plank.JPG"));
                plank3.Visibility = Visibility.Visible;
                lengthimage2.Visibility = Visibility.Visible;
                answer3.Visibility = Visibility.Visible;
                pieces3.Visibility = Visibility.Visible;

                var ans = calculationObject.cube3_side_length(CalculationData.length, CalculationData.width, CalculationData.breadth);


                answer1.Text = (Math.Abs(ans[0])).ToString() + " " + CalculationData.unit;
                answer2.Text = Math.Abs(ans[1]).ToString() + " " + CalculationData.unit;
                answer3.Text = Math.Abs(ans[2]).ToString() + " " + CalculationData.unit;
            }
            if (parameter.Equals("c4"))
            {
                plank1.Visibility = Visibility.Visible;
                lengthimage.Visibility = Visibility.Visible;
                answer1.Visibility = Visibility.Visible;

                answer1.Text = calculationObject.cube1_side_length(CalculationData.length).ToString() + " " + CalculationData.unit;
            }
            volumetext.Text = "Volume of the Cube is " + calculationObject.cubevolume(CalculationData.length).ToString() + " " + CalculationData.unit;
        }

        private void view3dClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CubeViewer));
        }
    }
}
