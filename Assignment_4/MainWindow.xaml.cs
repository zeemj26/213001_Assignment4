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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_4
{
    
    public partial class MainWindow : Window
    {
        public Person Person { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Person = new Person() { FirstName = "Saad", LastName = "Khan", Age = 21 };
            DataContext = this;
        }
    }
}
