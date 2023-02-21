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
    /// Interaction logic for contains.xaml
    /// </summary>
    public partial class contains : Page
    {
        public contains()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            string str = txtbox_string.Text;
            string con = txtbox_remove.Text;
            bool c = str.Contains(con);
            if(!c)
            {
                String result = "The string does not contains the given character or word";
                MessageBox.Show(result);
            }
            else
            {
                string result = "The string contains the " + con + " character";
                MessageBox.Show(result);
            }
        }
    }
}
