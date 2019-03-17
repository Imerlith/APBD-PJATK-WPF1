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
using System.Windows.Shapes;

namespace Task3
{
    /// <summary>
    /// Interaction logic for Zadanie2.xaml
    /// </summary>
    public partial class Zadanie2 : Window
    {
        public Zadanie2()
        {
            InitializeComponent();
        }

        private void StatusCBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StatusTextBox.Text = StatusCBox.Text;
        }

        private void ZamknijBtn_OnClick(object sender, RoutedEventArgs e)
        {
           Close();
        }
    }
}
