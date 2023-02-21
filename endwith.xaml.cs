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
    /// Interaction logic for endwith.xaml
    /// </summary>
    public partial class endwith : Page
    {
        public endwith()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            string str = txtbox_string.Text;
            string ch = txtbox_remove.Text;
            bool isstart = str.EndsWith(ch);
            if (isstart)
            {
                string ch1 = "Yeah it ends with the given character";
                MessageBox.Show(ch1);
            }
            else
            {
                string ch1 = "No it does not ends with the given character";
                MessageBox.Show(ch1);
            }
        }
    }
}
