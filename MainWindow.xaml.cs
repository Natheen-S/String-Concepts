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

namespace Strings_
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton== MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(e.RightButton== MouseButtonState.Pressed)
            {
                Close();
            }
        }

        private void btn_remove_Click(object sender, RoutedEventArgs e)
        {
            remove rem = new remove();
            frmain.Content= rem;
        }

        private void btn_substring_Click(object sender, RoutedEventArgs e)
        {
            substring  sub = new substring();
            frmain.Content= sub;
        }

        private void btn_replace_Click(object sender, RoutedEventArgs e)
        {
            replace rep = new replace();
            frmain.Content= rep;
        }

        private void btn_contains_Click(object sender, RoutedEventArgs e)
        {
            contains con = new contains();
            frmain.Content= con;
        }

        private void btn_startswith_Click(object sender, RoutedEventArgs e)
        {
            startswith st = new startswith();
            frmain.Content= st;
        }

        private void btn_endwith_Click(object sender, RoutedEventArgs e)
        {
            endwith end = new endwith();
            frmain.Content= end;
        }

        private void btn_reverse_Click(object sender, RoutedEventArgs e)
        {
            reverse rev     = new reverse();    
            frmain.Content= rev;
        }
    }
}
