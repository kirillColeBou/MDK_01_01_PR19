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
