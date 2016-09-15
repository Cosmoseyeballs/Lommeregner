using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Lommeregner
{
    public partial class RelativeLayoutPage : ContentPage
    {
        public RelativeLayoutPage()
        {
            InitializeComponent();

            var relativeLayout = new RelativeLayout();

            var box1 = new BoxView
            {
                BackgroundColor = Color.Pink,
                WidthRequest = 40
                
            };
            var box2 = new BoxView
            {
                BackgroundColor = Color.Pink
            };


            relativeLayout.Children.Add(box1, Constraint.RelativeToParent((parent) =>
            {
                return (parent.Width * 0.5) - (box1.WidthRequest * 0.5);
            })
            
            );




            Content = relativeLayout;
        }
    }
}
