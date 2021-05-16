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

namespace homework5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string cur = "X";
        private int steps = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            initBoard();
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(uxGrid.Children.Count.ToString());
            string[] coordinates = ((Button)sender).Tag.ToString().Split(",");
            int x = int.Parse(coordinates[0]);
            int y = int.Parse(coordinates[1]);
            Button button = (Button)uxGrid.Children[x * 3 + y];
            if (button.HasContent)
            {
                return;
            }
            button.Content = cur;
            if (isCurWin(x, y, cur))
            {
                disableBoard();
                MessageBox.Show(string.Format("{0} is the winner!", cur));
                return;
            }
            switchCur();
            steps++;
            if(steps == 9)
            {
                disableBoard();
                MessageBox.Show("No winner!", cur);
            }
        }

        private void switchCur()
        {
            if (cur.Equals("X"))
            {
                cur = "O";
            }
            else
            {
                cur = "X";
            }
        }

        private void disableBoard()
        {
            foreach (Button child in uxGrid.Children)
            {
                child.IsEnabled = false;
            }
        }

        private void enableBoard()
        {
            foreach (Button child in uxGrid.Children)
            {
                child.IsEnabled = true;
            }
        }

        private void initBoard()
        {
            cur = "X";
            steps = 0;
            foreach (Button child in uxGrid.Children)
            {
                child.IsEnabled = true;
                child.Content = null;
            }
        }

        private bool isCurWin(int x, int y, string piece)
        {
            bool win = true;
            for (int i = 0; i < 3; i++)
            {
                if (!((Button)uxGrid.Children[i * 3 + y]).HasContent || !((Button)uxGrid.Children[i * 3 + y]).Content.Equals(piece))
                {
                    win = false;
                    break;
                }
            }
            if (win)
            {
                return win;
            }

            win = true;
            for (int j = 0; j < 3; j++)
            {
                if (!((Button)uxGrid.Children[x * 3 + j]).HasContent || !((Button)uxGrid.Children[x * 3 + j]).Content.Equals(piece))
                {
                    win = false;
                    break;
                }
            }
            if (win)
            {
                return win;
            }

            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (!((Button)uxGrid.Children[i * 3 + i]).HasContent || !((Button)uxGrid.Children[i * 3 + i]).Content.Equals(piece))
                {
                    win = false;
                    break;
                }
            }
            if (win)
            {
                return win;
            }

            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (!((Button)uxGrid.Children[i * 3 + (2 - i)]).HasContent || !((Button)uxGrid.Children[i * 3 + (2 - i)]).Content.Equals(piece))
                {
                    win = false;
                    break;
                }
            }
            return win;
        }
    }
}
