using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp3calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cboOperation.Items.Add("+");
            cboOperation.Items.Add("-");    
            cboOperation.Items.Add("*");    
            cboOperation.Items.Add("/");
            cboOperation.SelectedIndex = 0;
            lblResult.Content = string.Empty;   
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtArg1.Text = string.Empty;    
            txtArg2.Text = string.Empty;    
            lblResult.Content = string.Empty;   
            
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string expression = txtArg1.Text + cboOperation.SelectedIndex + txtArg2 ;
            string.IsNullOrEmpty(txtArg1.Text);
            string.IsNullOrEmpty(txtArg2.Text);
            lblResult.Content = new DataTable().Compute(expression, null);

        }
    }
}
