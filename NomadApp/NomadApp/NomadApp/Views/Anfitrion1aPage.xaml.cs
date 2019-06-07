using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NomadApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anfitrion1aPage : ContentPage
    {
        public Anfitrion1aPage()
        {
            InitializeComponent();
            btncomenzar.Clicked += Btncomenzar_Clicked;
        }

        private void Btncomenzar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new AnfitrionRegisterPage());
        }
    }
}