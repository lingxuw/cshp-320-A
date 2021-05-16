using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace homework4
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

        private bool isZipValid(string zip)
        {
            string usZipPattern1 = @"[0-9]{5}";
            string usZipPattern2 = @"[0-9]{5}-[0-9]{4}";
            string canZipPattern = @"([A-Z][0-9]){3}";
            Regex re = null;
            switch (zip.Length)
            {
                case 5:
                    re = new Regex(usZipPattern1);
                    break;
                case 6:
                    re = new Regex(canZipPattern);
                    break;
                case 10:
                    re = new Regex(usZipPattern2);
                    break;
                default:
                    return false;
            }

            return re.Matches(zip).Count == 1;
        }

        private void uxZip_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isZipValid(uxZip.Text))
            {
                uxSubmit.IsEnabled = true;
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }
        }
    }
}
