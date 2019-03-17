using DeansOfficeApp.Models;
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

namespace DeansOfficeApp
{
    /// <summary>
    /// Interaction logic for PersonDetailsWindow.xaml
    /// </summary>
    public partial class PersonDetailsWindow : Window
    {
        public PersonDetailsWindow(Student student)
        {
            InitializeComponent();
            FillForm(student);
            CloseMenuItem.Click += CloseMenuItem_Click;
        }

        private  void FillForm(Student student)
        {
            FlNameTextBox.Text = student.LastName+ " " + student.FirstName;
            IndexTextBox.Text = student.IndexNumber;
            YearTextBox.Text =""+student.Year;
            SemesterTextBox.Text = student.Semester;
            SpecializationTextBox.Text = student.Specialization;

        }
        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
