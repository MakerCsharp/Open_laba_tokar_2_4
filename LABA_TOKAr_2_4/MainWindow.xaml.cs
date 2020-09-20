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

namespace LABA_TOKAr_2_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AdventureWorksLT2008REntities dataEntities = new AdventureWorksLT2008REntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from Customer in dataEntities.Customer
            where Customer.Title == "Mr."
            orderby Customer.Title
            select new { Customer.FirstName,Customer.MiddleName,Customer.LastName};

            dataGrid1.ItemsSource = query.ToList();
        }
    }
}
