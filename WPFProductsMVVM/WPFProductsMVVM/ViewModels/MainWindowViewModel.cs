using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFProductsMVVM.Infrastructure;
using WPFProductsMVVM.Models;

namespace WPFProductsMVVM.ViewModels
{
    public class MainWindowViewModel: INotifyPropertyChanged
    {
        private Product? selectedProduct;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Product>? Products { get; set; }

        public Product? SelectedProduct
        {
            get => selectedProduct;
            set
            {
                if(selectedProduct != value)
                {
                    selectedProduct = value;
                    OnPropertyChanged();
                }
            }
        }

        ICommand? deleteCommand;

        public ICommand DeleteCommand
        {
            get
            {
                return deleteCommand??(deleteCommand = new RelyCommand(DelCommandMethod, CanExecuteDelMethod));
            }
        }

        void DelCommandMethod(object param)
        {
            Products?.Remove(SelectedProduct);
        }

        bool CanExecuteDelMethod(object param)
        {
            return SelectedProduct != null;
        }

        public MainWindowViewModel()
        {
            Products = new ObservableCollection<Product>()
            {
                new Product(){Title="Apple", Country="Ukraine", Price=27, Image =  "../img/1.jpg"},
                new Product(){Title="Orange", Country="USA", Price=46, Image =  "../img/2.jpg"},
                new Product(){Title="Pineaple", Country="Australia", Price=120, Image =  "../img/3.jpg"},
                new Product(){Title="Avacado", Country="Mexico", Price=95, Image =  "../img/4.jpg"},
                new Product(){Title="Banana", Country="Egypt", Price=32, Image =  "../img/5.jpg"},
            };
        }

        private void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
