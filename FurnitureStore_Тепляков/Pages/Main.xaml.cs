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
        public List<Classes.Item> Items = new List<Classes.Item>();
        public Main()
        {
            InitializeComponent();
            Items.Add(new Classes.Item("Cтол деревянный", 10000, "table.jpg"));
            Items.Add(new Classes.Item("Cтол", 6000, "table2.jpg"));
            Items.Add(new Classes.Item("Диван", 15000, "sofa.jpg"));
            Items.Add(new Classes.Item("Диван раздвижной", 25000, "sofa2.jpg"));
            Items.Add(new Classes.Item("Шкаф-стенка", 9000, "cupboard.jpeg"));
            Items.Add(new Classes.Item("Шкаф с раздвижными дверями", 14000, "cupboard2.jpg"));
            LoadItems();
        }

        public void LoadItems()
        {
            parent.Children.Clear();
            foreach (var item in Items)
            {
                parent.Children.Add(new Elements.Item(item));
            }   
        }
    }
}
