﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConstructorsPage : ContentPage
    {
        public ConstructorsPage()
        {
            InitializeComponent();
        }
    }
}