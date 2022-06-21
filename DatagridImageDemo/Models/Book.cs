using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatagridImageDemo.Models
{
    [INotifyPropertyChanged]
    public partial class Book
    {
        #region Constructors
        public Book(string title, string description, string imagePath)
        {
            _title = title;
            _description = description;
            _imagePath = imagePath;
        }
        #endregion Constructors

        #region Private fields
        [ObservableProperty]
        private string _title;
        [ObservableProperty]
        private string _description;
        [ObservableProperty]
        private string _imagePath;
        #endregion Private fields
    }
}
