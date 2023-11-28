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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FurnitureStore_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        public static List<Classes.Item> Items_table = new List<Classes.Item>();
        public static List<Classes.Item> Items_sofa = new List<Classes.Item>();
        public static List<Classes.Item> Items_cupboard = new List<Classes.Item>();

        public static bool iTable = false;
        public static bool iSofa = false;
        public static bool iCupboard = false;

        public static Catalog catalog;

        public Catalog()
        {
            InitializeComponent();
            catalog = this;
            Items_table.Clear();
            Items_sofa.Clear();
            Items_cupboard.Clear();
            LoadItems();
        }

        public void LoadItems()
        {
            foreach (var item in Main.Items)
            {
                if (item.filter == "стол")
                    Items_table.Add(item);
                if (item.filter == "диван")
                    Items_sofa.Add(item);
                if (item.filter == "шкаф")
                    Items_cupboard.Add(item);
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Main.Pages_Open = false;
            MainWindow.mainWindow.OpenPage(MainWindow.pages.main);
        }

        private void Cansel(object sender, RoutedEventArgs e)
        {
            iTable = false; 
            iSofa = false; 
            iCupboard = false;
            Main.main.parent.Children.Clear();
            Main.Pages_Open = false;
            foreach (var item in Main.Items)
            {
                Main.main.parent.Children.Add(new Elements.Item(item));
            }
            MainWindow.mainWindow.OpenPage(MainWindow.pages.main);
        }

        private void Filter_1(object sender, RoutedEventArgs e)
        {
            iTable = true;
            Main.Pages_Open = false;
            Main.main.parent.Children.Clear();
            foreach(var item in Items_table)
            {
                Main.main.parent.Children.Add(new Elements.Item(item));
            }
            MainWindow.mainWindow.OpenPage(MainWindow.pages.main);
        }
        private void Filter_2(object sender, RoutedEventArgs e)
        {
            iSofa = true;
            Main.Pages_Open = false;
            Main.main.parent.Children.Clear();
            foreach (var item in Items_sofa)
            {
                Main.main.parent.Children.Add(new Elements.Item(item));
            }
            MainWindow.mainWindow.OpenPage(MainWindow.pages.main);
        }
        private void Filter_3(object sender, RoutedEventArgs e)
        {
            iCupboard = true;
            Main.Pages_Open = false;
            Main.main.parent.Children.Clear();
            foreach (var item in Items_cupboard)
            {
                Main.main.parent.Children.Add(new Elements.Item(item));
            }
            MainWindow.mainWindow.OpenPage(MainWindow.pages.main);
        }
    }
}
