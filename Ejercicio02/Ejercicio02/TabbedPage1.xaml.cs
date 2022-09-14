﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //Nos hará volver al menú principal
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }
    }
}