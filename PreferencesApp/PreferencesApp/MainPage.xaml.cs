using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace PreferencesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


                eNombre.Text = Preferences.Get("pNombre", string.Empty);

                swSesion.IsToggled = Preferences.Get("swSesion", false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("swSesion", swSesion.IsToggled);
            Preferences.Set("pNombre", eNombre.Text);
        }
    }
}
