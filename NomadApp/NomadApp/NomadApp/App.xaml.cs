namespace NomadApp
{
    using NomadApp.Views;
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    public partial class App : Application
    {
        #region Constructores
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginNomadaPage2()); //La app arranca por la PrincipalPage
        }
        #endregion

        #region MyRegion
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        #endregion

    }
}
