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
    public partial class ReservarEspacioPage : ContentPage
    {
        public ReservarEspacioPage()
        {
            InitializeComponent();
            btnMostrarMas.Clicked += BtnMostrarMas_Clicked;
            btnComenzar.Clicked += BtnComenzar_Clicked;
            btnVerTodas.Clicked += BtnVerTodas_Clicked;

        }

        private void BtnVerTodas_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new MostrarMasEspaciosPage());
        }

        private void BtnComenzar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new MostrarMasEspaciosPage());
        }

        private void BtnMostrarMas_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new MostrarMasEspaciosPage());
        }
    }
}