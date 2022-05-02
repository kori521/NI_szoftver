﻿using LibAdmin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibAdmin.View
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Page
    {
        internal MainViewModel model;
        public MainView(MainViewModel model)
        {
            InitializeComponent();
            model = new MainViewModel();
            DataContext = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
