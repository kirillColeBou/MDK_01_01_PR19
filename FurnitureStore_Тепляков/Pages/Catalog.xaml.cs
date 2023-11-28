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

namespace FurnitureStore_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {

        public Catalog()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.OpenPage(MainWindow.pages.main);
        }

        private void Filter_1(object sender, RoutedEventArgs e)
        {
            Main.main.parent.Children.Clear();
            
            MainWindow.mainWindow.OpenPage(MainWindow.pages.main);
        }
        private void Filter_2(object sender, RoutedEventArgs e)
        {
            Main.main.parent.Children.Clear();
            
            MainWindow.mainWindow.OpenPage(MainWindow.pages.main);
        }
        private void Filter_3(object sender, RoutedEventArgs e)
        {
            Main.main.parent.Children.Clear();
           
            MainWindow.mainWindow.OpenPage(MainWindow.pages.main);
        }
    }
}
