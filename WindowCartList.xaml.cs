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
using System.Windows.Shapes;
using ClassLibrary;

namespace Exam22
{
    /// <summary>
    /// Логика взаимодействия для WindowCartList.xaml
    /// </summary>
    public partial class WindowCartList : Window
    {
        public WindowCartList(List<Books> booksList)
        {
            InitializeComponent();
            LVCart.Items.Clear();
            LVCart.ItemsSource = booksList;
        }
    }
}
