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

namespace Employee
{
    /// <summary>
    /// Interaction logic for ViewEmployee.xaml
    /// </summary>
    public partial class ViewEmployee : Window
    {
        public ViewEmployee()
        {
            InitializeComponent();
            this.DataContext = new ViewEmployeeViewModel();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
