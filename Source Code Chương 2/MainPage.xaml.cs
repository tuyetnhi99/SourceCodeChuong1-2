using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlExamples
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void cmdArrayPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArrayPage());
        }

        private void cmdRefencePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReferencePage());
        }

        private void cmdConstructorsPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConstructorsPage());
        }

        private void cmdPropertyValuesPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PropertyValuesPage());
        }
    }
}