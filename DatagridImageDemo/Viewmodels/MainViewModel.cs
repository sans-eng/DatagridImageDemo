using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatagridImageDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatagridImageDemo.Viewmodels
{
    [INotifyPropertyChanged]
    public partial class MainViewModel
    {
        #region Constructors
        public MainViewModel()
        {
            string rootDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            _books.Add(new Book("Book 1", "This is Book one", Path.Combine(rootDirectory, "image1.png")));
            _books.Add(new Book("Book 1", "This is Book one", Path.Combine(rootDirectory, "image2.png")));
            _books.Add(new Book("Book 1", "This is Book one", Path.Combine(rootDirectory, "image3.png")));
        }
        #endregion Constructors

        #region Private fields
        [ObservableProperty]
        private ObservableCollection<Book> _books = new();
        [ObservableProperty]
        private Book? _selectedBook;
        #endregion Private fields

        #region Private methods
        [ICommand]
        private void OnClickedDelete()
        {
            if (SelectedBook != null)
            {
                string imagePath = SelectedBook.ImagePath;
                Books.Remove(SelectedBook);
                File.Delete(imagePath);
            }
        }
        #endregion Private methods
    }
}
