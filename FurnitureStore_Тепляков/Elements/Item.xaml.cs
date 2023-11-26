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
            }
        }
    }
}
