namespace NomadApp.Views

{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnfitrionRegisterPage : ContentPage
    {
        public AnfitrionRegisterPage()
        {
            InitializeComponent();
            btnCrearCuentaAnfitrion.Clicked += BtnAnfitrionRegister_Clicked;
        }

        private void BtnAnfitrionRegister_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new LoginAnfitrionPage());
        }
    }
}