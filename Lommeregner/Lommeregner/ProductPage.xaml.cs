using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Lommeregner
{
    public partial class ProductPage : ContentPage
    {

        private ProductViewModel productViewModel;
        private ProductServiceClient productServiceClient;


        public ProductPage()
        {

            InitializeComponent();
        }

        private async void ProductIdButton_Clicked(object sender, EventArgs e)
        {
            int id = Int32.Parse(ProductIdEntry.Text);
            var product = await new ProductServiceClient().GetProduct(id);

            ProductList.BindingContext = product;

        }
    }
}
