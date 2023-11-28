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
using System.IO;
using FurnitureStore_Тепляков.Pages;

namespace FurnitureStore_Тепляков.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Classes.Item items;
        public static int sum = 0;
        public static Dictionary<string, int> basket = new Dictionary<string, int>();

        public Item(Classes.Item item)
        {
            InitializeComponent();
            if(item != null)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "/Image/Image_item/" + item.img))
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Image/Image_item/" + item.img));
                else
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Image/Image_item/table.jpg"));
                price.Content = item.price + " р.";
                name.Content = item.name;
                Addgoods();
            }
        }

        public void Addgoods()
        {
            minus.Click += delegate
            {
                if (count.Text != "")
                    if (int.Parse(count.Text) > 0)
                    {
                        count.Text = (int.Parse(count.Text) - 1).ToString();
                    }
            };
            plus.Click += delegate
            {
                if (count.Text != "")
                    if (int.Parse(count.Text) < 10)
                    {
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                    };
            };
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            foreach (var item in Main.Items)
            {
                if (this.name.Content.ToString() == item.name)
                {
                    int countToAdd = Convert.ToInt32(count.Text);
                    if (basket.ContainsKey(item.name))
                    {
                        countToAdd -= basket[item.name];
                        basket[item.name] += countToAdd;
                    }
                    else
                    {
                        basket.Add(item.name, countToAdd);
                    }
                    sum += item.price * countToAdd;
                    Main.main.korzina.Content = $"Корзина ({sum} р.)";
                }
            }
        }
    }
}
