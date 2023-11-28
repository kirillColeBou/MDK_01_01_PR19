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
        public static Pages.Main main;
        public static bool IsSortirovochka = false;
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
            LoadItems(Items);
        }

        public void LoadItems(List<Classes.Item> ahaha)
        {
            parent.Children.Clear();
            foreach (var item in ahaha)
            {
                parent.Children.Add(new Elements.Item(item));
            }   
        }

        private void Catalog(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.OpenPage(MainWindow.pages.catalog);
        }
    }
}
