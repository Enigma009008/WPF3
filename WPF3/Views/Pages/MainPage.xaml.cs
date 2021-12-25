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
using WPF3.Class;
using WPF3.Model;

namespace WPF3.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataSource.ItemsSource = AppData.db.Book.ToList();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            DataSource.ItemsSource = AppData.db.Book.Where(item => item.Title.Contains(TxbSearch.Text)).ToList();
        }

       
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ActionPage(new Model.Book()));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var EditBook = (Book)DataSource.SelectedItem;
            if (EditBook != null)
            {
                NavigationService.Navigate(new ActionPage(EditBook));
            }
            else
            {
                MessageBox.Show("Не выбрана книга!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);          
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var RemoveBook = (Book)DataSource.SelectedItem;
            if (RemoveBook != null)
            {
                AppData.db.Book.Remove(RemoveBook);
                AppData.db.SaveChanges();
                MessageBox.Show("Книга удалена!", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                Page_Loaded(null, null);
            }
            else
            {
                MessageBox.Show("Не выбрана книга!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
