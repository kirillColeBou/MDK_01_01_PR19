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

namespace FurnitureStore_Тепляков.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Classes.Item items;
        public string[] allPrice;
        public int fullPrice;
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
                allPrice = item.price.ToString().Split(' ');
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
                    if (int.Parse(count.Text) < 15)
                    {
                        count.Text = (int.Parse(count.Text) + 1).ToString();
                    };
            };
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < Pages.Main.main.parent.Children.Count; i++)
            {
                fullPrice += Convert.ToInt32(allPrice[i]);
            }
            Pages.Main.main.korzina.Content = fullPrice.ToString();
        }
    }
}
