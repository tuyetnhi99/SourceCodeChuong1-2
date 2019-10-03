using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsExample
{
    public partial class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            InitializeComponent();
        }

        protected void ButtonClicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = "IT IS SO";
        }

        async protected void ImageTapped(object sender, EventArgs e)
        {
            Image image = (Image)sender;

            image.Opacity = 0.5f;
            await Task.Delay(200);
            image.Opacity = 1f;
        }
    }
}
