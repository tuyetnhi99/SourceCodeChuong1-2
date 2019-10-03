using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyValuesPage : ContentPage
    {
        public PropertyValuesPage()
        {
            InitializeComponent();
        }

        protected void ButtonClicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = "IT IS SO";
        }
    }
}