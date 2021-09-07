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

namespace WpfAutoOlio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Car volvo = new Car();
        Car ford = new Car();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAuto1_Click(object sender, RoutedEventArgs e)
        {
            Car volvo = new Car();
            volvo.Color = txtColor.Text;
            volvo.Modle = txtModel.Text;
            volvo.MaxSpeed = int.Parse(txtMaxSpeed.Text);
            txtColor.Text = "";
            txtModel.Text = "";
            txtMaxSpeed.Text = "";
        }

        public void ShowCarInfo(Car auto)
        {
            string message = "Model:" + auto.Modle + "\n" +
                "Color: " + auto.Color + "\n" +
                "Maxspeed: " + auto.MaxSpeed + "\n" +
                "Engine running?: " + auto.Running;
        }

        private void btnAuto1Info_Click(object sender, RoutedEventArgs e)
        {
            ShowCarInfo(volvo);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (sender == btnStart)
            {
                volvo.StartEngine();
                if (volvo.Running == true)
                {
                    btnIndicator.Background = Brushes.PaleGreen;
                }
            } else if (sender == btnStart2)
            {
                ford.StartEngine();
                if (volvo.Running == true)
                {
                    btnIndicator2.Background = Brushes.PaleGreen;
                }
            }
            
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (sender == btnStop)
            {
                volvo.StopEngine();
                if (volvo.Running == false)
                {
                    btnIndicator.Background = Brushes.Yellow;
                }
            }
            else if (sender == btnStop2)
            {
                ford.StartEngine();
                if (ford.Running == false)
                {
                    btnIndicator2.Background = Brushes.Yellow;
                }
            }
        }

        private void btnAuto2_Click(object sender, RoutedEventArgs e)
        {
            Car ford = new Car();
            ford.Color = txtColor.Text;
            ford.Modle = txtModel.Text;
            ford.MaxSpeed = int.Parse(txtMaxSpeed.Text);
            txtColor.Text = "";
            txtModel.Text = "";
            txtMaxSpeed.Text = "";
        }

        private void btnAuto2Info_Click(object sender, RoutedEventArgs e)
        {
            ShowCarInfo(ford);
        }

        private void btnStart2_Click(object sender, RoutedEventArgs e)
        {
            //pensive :(
        }

        private void btnStop2_Click(object sender, RoutedEventArgs e)
        {
            //pensive :(
        }
    }
}
