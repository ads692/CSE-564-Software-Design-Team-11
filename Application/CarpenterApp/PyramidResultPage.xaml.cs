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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CarpenterApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PyramidResultPage : Page
    {
        public PyramidResultPage()
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
            if (parameter.Equals("a1") || parameter.Equals("a2"))
            {
                pieces1.Text = "3 Pieces of";
                pieces2.Text = "3 Pieces of";
                

                var ans = calculationObject.triangle_pyramid_sidelength(CalculationData.length);


                answer1.Text = ans.ToString() + " " + CalculationData.unit;
                answer2.Text = ans.ToString() + " " + CalculationData.unit;
                volumetext.Text = "Volume of the Cube is " + calculationObject.triangular_pyramidvolume_(CalculationData.length).ToString() + " " + CalculationData.unit;
            }
            if (parameter.Equals("b1") || parameter.Equals("b2"))
            {
                pieces1.Text = "4 Pieces of";
                pieces2.Text = "4 Pieces of";


                var ans = calculationObject.square_pyramid_sidelength(CalculationData.length);


                answer1.Text = ans.ToString() + " " + CalculationData.unit;
                answer2.Text = ans.ToString() + " " + CalculationData.unit;
                volumetext.Text = "Volume of the Cube is " + calculationObject.rectangular_pyramidvolume_(CalculationData.length).ToString() + " " + CalculationData.unit;
            }
        }

        private void view3dClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(_3dPyradmidPage));
        }
    }
}
