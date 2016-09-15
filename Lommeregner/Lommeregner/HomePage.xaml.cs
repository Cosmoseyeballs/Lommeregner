using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Lommeregner
{
    public partial class HomePage : ContentPage
    {
     
        public HomePage()
        {
            InitializeComponent();

            var btn = new Button {
                Text = "Gå til Lommeeregner"
            };
            btn.Clicked += Btn_Clicked;

            var btnGridLommeeregner = new Button
            {
                Text = "Gå til Lommeeregner Grid"
            };
            btnGridLommeeregner.Clicked += BtnLommeeregnerGrid_Clicked;

            var btnGrid = new Button
            {
                Text = "Gå til Grid"
            };
            btnGrid.Clicked += BtnGrid_Clicked;


            var btnRelativeLayout = new Button
            {
                Text = "Gå til btnRelativeLayout"
            };
            btnRelativeLayout.Clicked += BtnbtnRelativeLayout_Clicked;

            Content = new StackLayout
            {
                Children =
                {
                    btn,btnRelativeLayout, btnGridLommeeregner, btnGrid
                }
            };

           
            var settings = new ToolbarItem {
                Text ="hej",
                Icon= "icon.png",
                Command = new Command(() =>  ShowSettingsPage())
            };
            

            this.ToolbarItems.Add(settings);


            var animation = new Animation(callback: d => btn.Rotation = d,
                                start: btn.Rotation,
                                end: btn.Rotation + 360,
                                easing: Easing.SpringOut);
            animation.Commit(btn, "Loop", length: 800);


        }

        private void BtnbtnRelativeLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayoutPage());
        }

        private void BtnLommeeregnerGrid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LommeregnerGridPage());
        }

        private void BtnGrid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyGridPage());
        }

        private void ShowSettingsPage()
        {
            Navigation.PushAsync(new LommeregnerPage());

        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LommeregnerPage());
        }

        
    }
}
