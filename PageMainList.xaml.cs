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

namespace Exam22
{
    /// <summary>
    /// Логика взаимодействия для PageMainList.xaml
    /// </summary>
    public partial class PageMainList : Page
    {
        public PageMainList()
        {
            InitializeComponent();
            LVBooks.ItemsSource = ClassBase.DB.Books.ToList();
        }

        WindowCartList win;
        private void BUTAddToCart_Click(object sender, RoutedEventArgs e)
        {
            var selectedList = LVBooks.SelectedItems;
            TBOrderCount.Text = "Количество выбранных книг: " + selectedList.Count;
            int totalSum = 0;

            foreach(Books book in selectedList)
            {
                totalSum += book.Cost;
            }
            TBTotalCost.Text = "Стоимость покупки: " + totalSum;

            
        }
    }
}
