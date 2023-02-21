using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace Strings_
{
    /// <summary>
    /// Interaction logic for replace.xaml
    /// </summary>
    public partial class replace : Page
    {
        public replace()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            string str = txtbox_string.Text;
            string old = txtbox_old.Text;
            string to = txtbox_new.Text;
            string after = str.Replace(old, to);
            MessageBox.Show(after);
        }
    }
}
