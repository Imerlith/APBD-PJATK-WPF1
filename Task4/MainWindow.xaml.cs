﻿using Cwiczenia4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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

namespace Cwiczenia4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Student> students;
        public MainWindow()
        {
            InitializeComponent();
            //LoadDataToListBox1();
            LoadDataToListBoxAndDataGrid();
            ConnectToDB();
        }

        private void LoadDataToListBox1()
        {
            StudentsListBox.Items.Add(new ListBoxItem { Content = "Kwiatkowska" });
            StudentsListBox.Items.Add("Wieczorowski");
            StudentsListBox.Items.Add(new Student {IdStudent=1, Imie= "Jakub", Nazwisko="Dzieciątko" });
        }

        private void LoadDataToListBoxAndDataGrid()
        {
            students = new ObservableCollection<Student>();
            students.Add(new Student { IdStudent = 1, Imie = "Jakub", Nazwisko = "Dzieciątko" ,Plec = true });
            students.Add(new Student { IdStudent = 2, Imie = "Przemysław", Nazwisko = "Gołębski" });
            StudentsListBox.ItemsSource = students;
            StudentsDataGrid.ItemsSource = students;
        }

        private void ShowSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(StudentsListBox.SelectedItem.ToString());
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new Student { IdStudent = 3, Imie = "Paweł", Nazwisko = "Kalbarczyk" });
        }
        private void ConnectToDB()
        {
            string connectionString = "Server = db-mssql; Integrated Security=SSPI;Database=s16540";
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("select * from emp", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nazwisko = reader["ename"].ToString();
                        int index = int.Parse(reader["sal"].ToString());
                        students.Add(new Student { Nazwisko = nazwisko, IdStudent = index });
                    }
                }
            }
        }
    }
}
