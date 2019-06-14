namespace NomadApp.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using NomadApp.Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class MostrarMasEspaciosViewModel : BaseViewModel
    {
        #region Attributes 
        
        private string email;
        private string password;
        private bool IsEnabled;
        #endregion

        #region Properties
        

        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        #endregion


        #region Constructors
        public MostrarMasEspaciosViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand CrearPerfilCommand //Le sacamos el command del Login
        {
            get
            {
                return new RelayCommand(CrearPerfil);
            }
        }

        private async void CrearPerfil()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes entrar un email.",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes entrar una contraseña.",
                    "Aceptar");
                return;
            }  

            this.IsEnabled = false;

            this.Email = string.Empty;
            this.Password = string.Empty;


            //aquí ponemos la página donde se direcciona cuando hacemos REGISTRER
            //Garantizamos que antes de PINTAR la ReservarEspacioPage,estamos estableciendo la ReservarEspacioViewModel
            MainViewModel.GetInstance().LoginNomada2 = new LoginNomada2ViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LoginNomada2Page());


        }
        #endregion
    }

}
