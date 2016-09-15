using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Lommeregner
{
    public partial class LommeregnerPage : ContentPage
    {
        int newNumber = 0;
        int oldNumber = 0;

        public LommeregnerPage()
        {
            InitializeComponent();
            
        }

        private void btnNumber_Clicked(object sender, EventArgs e)
        {
            string btnText = (sender as Button).Text;
            newNumber = Int32.Parse(btnText);



            ResultLabel.Text = newNumber.ToString(); // vis hvad der er valgt
            
        }

        private void btnFun_Clicked(object sender, EventArgs e)
        {
            string btnText = (sender as Button).Text;
            int result = 0;

            switch (btnText)
            {
                case "-":
                   result = (oldNumber - newNumber);
                    break;

                default:
                    break;
            }
            HistoriLabel.Text += " "+btnText +" " + newNumber;
            ResultLabel.Text = result.ToString();
            oldNumber = newNumber;

        }
    }
}
