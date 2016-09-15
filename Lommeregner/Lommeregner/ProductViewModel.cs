using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Lommeregner
{
    public partial class ProductViewModel : INotifyPropertyChanged
    {
        private string name;
        private string category;
        private decimal price;

        public event PropertyChangedEventHandler PropertyChanged;


        private void NotifyPropertyChanged(
            [CallerMemberName] String propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propName));
            }
        }

        public async Task<Product> LoadProductAsync(int id)
        {
            Product product = await new ProductServiceClient().GetProduct(id);
            Name = product.Name;
            Category = product.Category;
            Price = product.Price;
            return product;

        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public string Category
        {
            get { return this.category; }
            set
            {
                if (value != this.category)
                {
                    this.category = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value != this.price)
                {
                    this.price = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
