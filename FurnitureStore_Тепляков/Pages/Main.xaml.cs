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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public static List<Classes.Item> Items;
        public static Main main;
        public static bool Pages_Open = false;
        public Main()
        {
            InitializeComponent();
            Items = new List<Classes.Item>();
            Items.Add(new Classes.Item("Cтол деревянный", 10000, "table.jpg", "стол"));
            Items.Add(new Classes.Item("Cтол", 6000, "table2.jpg", "стол"));
            Items.Add(new Classes.Item("Диван", 15000, "sofa.jpg", "диван"));
            Items.Add(new Classes.Item("Диван раздвижной", 25000, "sofa2.jpg", "диван"));
            Items.Add(new Classes.Item("Шкаф-стенка", 9000, "cupboard.jpeg", "шкаф"));
            Items.Add(new Classes.Item("Шкаф с дверями", 14000, "cupboard2.jpg", "шкаф"));
            main = this;
            LoadItems();
        }

        public void LoadItems()
        {
            if(Pages_Open == false)
            {
                if(Catalog.iTable == false && Catalog.iSofa == false && Catalog.iCupboard == false)
                {
                    parent.Children.Clear();
                    foreach (var item in Items)
                    {
                        parent.Children.Add(new Elements.Item(item));
                    }
                }
                if (Catalog.iTable == true)
                {
                    parent.Children.Clear();
                    foreach (var item in Catalog.Items_table)
                    {
                        parent.Children.Add(new Elements.Item(item));
                    }
                }
                if (Catalog.iSofa == true)
                {
                    parent.Children.Clear();
                    foreach (var item in Catalog.Items_sofa)
                    {
                        parent.Children.Add(new Elements.Item(item));
                    }
                }
                if (Catalog.iCupboard == true)
                {
                    parent.Children.Clear();
                    foreach (var item in Catalog.Items_cupboard)
                    {
                        parent.Children.Add(new Elements.Item(item));
                    }
                }
            }
            Pages_Open = true;
        }

        private void CatalogClick(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.OpenPage(MainWindow.pages.catalog);
        }
    }
}
