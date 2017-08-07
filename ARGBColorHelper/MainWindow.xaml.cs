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

namespace ARGBColorHelper
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        CustomColorView ccv; 

        public MainWindow()
        {
            InitializeComponent();
        }
               
        private void ASlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           //ccv.A =(byte)ASlider.Value;
           //SolidColorBrush sc =  Resources.FindName("TestColorBrush") as SolidColorBrush;
           //FillRectangle();
        }

        private void RSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //ccv.R = (byte)RSlider.Value;
            //FillRectangle();
        }

        private void GSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //ccv.G = (byte)GSlider.Value;
            //FillRectangle();
        }

        private void BSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //ccv.B = (byte)BSlider.Value;
            //FillRectangle();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ccv = this.FindResource("TestFillColor") as CustomColorView; 
        }
    }
}
