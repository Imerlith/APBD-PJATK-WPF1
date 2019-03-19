﻿using System;
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
    /// Interaction logic for Zadanie3i4.xaml
    /// </summary>
    public partial class Zadanie3i4 : Window
    {
        
        public Zadanie3i4()
        {
            InitializeComponent();
            StudentDataGrid.Items.Add(new Student
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Indeks = "s111412"
            });
            StudentDataGrid.Items.Add(new Student
            {
                Imie = "Jakub",
                Nazwisko = "Dzieciątko",
                Indeks = "s312"
            });

            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
           
                var student = new Student { Imie = FNameTxtBox.Text, Nazwisko = LNameTxtBox.Text, Indeks = IndexTxtBox.Text };
                StudentDataGrid.Items.Add(student);
                StudentDataGrid.Items.Refresh();
            
        }
        

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = StudentDataGrid.SelectedCells[0].Item ;
            StudentDataGrid.Items.Remove(selectedItem);
            
        }
    }
}