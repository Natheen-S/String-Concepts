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
    /// Interaction logic for remove.xaml
    /// </summary>
    public partial class remove : Page
    {
        public remove()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            string str = txtbox_string.Text;
            int remove = Convert.ToInt32(txtbox_remove.Text);
            string after = str.Remove(remove);
            MessageBox.Show(after);
        }
    }
}
