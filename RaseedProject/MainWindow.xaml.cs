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

namespace RaseedProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void Save_Click(object sender, RoutedEventArgs e)
        {




=======
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new Login().Show();
>>>>>>> ec4059d594f0c8b2633bc847cbcc24b2f74a8f75
        }
    }
}
