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

namespace WpfApp1
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

        private void btnTervehdys_Click(object sender, RoutedEventArgs e)
        {
            string ilmoitus;
            ilmoitus = "Etunimi: " + txtEtunimi.Text + "\n" +
                "Sukunimi: " + txtSukunimi.Text + "\n" +
                "Osoite: " + txtOsoite.Text;
            MessageBox.Show(ilmoitus);
        }
    }
}
