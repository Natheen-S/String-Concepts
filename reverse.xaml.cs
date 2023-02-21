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
    /// Interaction logic for reverse.xaml
    /// </summary>
    public partial class reverse : Page
    {
        public reverse()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
           char[] ch = txtbox_string.Text.ToCharArray();
            Array.Reverse(ch);
            string res = new string(ch);
            txtbox_remove.Text = res;
        }
    }
}
