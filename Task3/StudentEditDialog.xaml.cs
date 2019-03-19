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
using Task3.Structure;

namespace Task3
{
    /// <summary>
    /// Interaction logic for StudentEditDialog.xaml
    /// </summary>
    public partial class StudentEditDialog : Window
    {
        public StudentEditDialog(Student student)
        {
            InitializeComponent();
            FNameTxtBox.Text = student.Imie;
            LNameTxtBox.Text = student.Nazwisko;
            IndexTxtBox.Text = student.Indeks;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
