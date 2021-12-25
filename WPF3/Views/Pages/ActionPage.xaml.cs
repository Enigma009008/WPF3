using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using Path = System.IO.Path;

namespace WPF3.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ActionPage.xaml
    /// </summary>
    public partial class ActionPage : Page
    {

        public Book Book { get; set; }
        public List <Author> Authors { get; set; }

        public List<Genre> Genres { get; set; }
        public List<Publisher> Publishers { get; set; }



        public ActionPage(Book book)
        {
            InitializeComponent();
            Book = book;
            Authors = AppData.db.Author.ToList();
            Genres = AppData.db.Genre.ToList();
            Publishers = AppData.db.Publisher.ToList();
            this.DataContext = this;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Book.ID == 0)
                {
                    AppData.db.Book.Add(Book);
                }
                File.Copy(file.FileName, $"images\\{Path.GetFileName(file.FileName).Trim()}", true);
                Book.GetPhoto = Path.GetFileName(file.FileName).Trim();
                AppData.db.SaveChanges();
                MessageBox.Show("Сохранение данных прошло успешно!", "Данные сохранены", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        OpenFileDialog file = new OpenFileDialog();
        private void SelectPhoto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                file.Filter = "Image (*.png; *.jpeg; *.jpg;) | *.png; *.jpeg; *.jpg;";
                if (file.ShowDialog() == true)
                {
                    BitmapImage imgBitmap = new BitmapImage(new Uri(file.FileName));
                    PhotoImage.Source = imgBitmap;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите пожалуйста картинку.", "Произошла ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
        
      
