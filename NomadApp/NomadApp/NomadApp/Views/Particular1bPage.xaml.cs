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
    public partial class Particular1bPage : ContentPage
    {
        public Particular1bPage()
        {
            InitializeComponent();
            btnexplorar.Clicked += Btnexplorar_Clicked;
        }

        
        private void Btnexplorar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new LoginNomada2Page());
        }
    }
}