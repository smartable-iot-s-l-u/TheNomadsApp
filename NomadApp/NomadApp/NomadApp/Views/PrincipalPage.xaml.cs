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
    public partial class PrincipalPage : ContentPage
    {
       

        public PrincipalPage()
        {
            InitializeComponent();
            btnafitrion.Clicked += Btnafitrion_Clicked;
            btnparticular.Clicked += Btnparticular_Clicked;
        }

        private void Btnparticular_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Particular1bPage());
        }

        private void Btnafitrion_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Anfitrion1aPage());
        }
    }
}