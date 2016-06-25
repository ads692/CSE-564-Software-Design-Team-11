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
    public sealed partial class InputPage : Page
    {
        public InputPage()
        {
            this.InitializeComponent();
            populateCombobox();
        }

        private void populateCombobox()
        {
            comboBox.DataContext = units;
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        String parameter;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            parameter = e.Parameter as string;
            
        }

        private void CalculateButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double l = Double.Parse(lengthInput.Text);
                double w = double.Parse(widthInput.Text);
                double b = double.Parse(breadthInput.Text);

                CalculationData obj = new CalculationData();
                CalculationData.length = Math.Abs(l);
                CalculationData.breadth = Math.Abs(b);
                CalculationData.width = Math.Abs(w);
                CalculationData.unit = comboBox.SelectionBoxItem as string;

                if(parameter.Equals("c1") || parameter.Equals("c2") || parameter.Equals("c3") || parameter.Equals("c4"))
                {
                    Frame.Navigate(typeof(ResultPage), parameter);
                }
                else
                {
                    Frame.Navigate(typeof(PyramidResultPage), parameter);
                }

                
            }
            catch(Exception ex)
            {
                warningText.Visibility = Visibility.Visible;
            }
        }

        private void LengthLostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                double l = Double.Parse(lengthInput.Text);
                lengthText.Text = lengthInput.Text;
                lengthText.Visibility = Visibility.Visible;
                lengthimage.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {

            }
        }

        private void breadthLostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                double b = Double.Parse(breadthInput.Text);
                breadthText.Text = breadthInput.Text;
                breadthText.Visibility = Visibility.Visible;
                widthimage.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {

            }
        }

        private void widthLostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                double w = Double.Parse(widthInput.Text);
                widthText.Text = widthInput.Text;
                widthText.Visibility = Visibility.Visible;
                breadthimage.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {

            }
        }
        String[] units = { "Feet", "Yard", "Inches", "Meters" };

        private void width_Copy_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
