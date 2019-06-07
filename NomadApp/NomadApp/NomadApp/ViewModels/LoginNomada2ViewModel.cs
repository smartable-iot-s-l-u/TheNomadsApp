namespace NomadApp.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using NomadApp.Views;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    //Tenemos que ligar esto con la MainViewModel
    public class LoginNomada2ViewModel : BaseViewModel
    {


        //Sólo a los que necesito refrescar le he de poner una propiedad privada

        #region Attributes //Atributos a refrescar
        private string email;
        private string password; //privados -->Minuscula
        private bool isRunning;
        private bool isEnabled;
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

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemembered { get; set; }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructors
        public LoginNomada2ViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand //Le sacamos el command del Login
        {
            get
            {
                return new RelayCommand(Login);
            }
        }




        private async void Login()
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
                    "Debes entrar un password.",
                    "Aceptar");
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            //Quemamos la contraseña
            if (this.Email != "123@gmail.com" || this.Password != "123")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email o Password incorrecto.",
                    "Aceptar");
                this.Password = string.Empty; //Vaciamos el campo del password
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            this.Email = string.Empty;
            this.Password = string.Empty;

            //aquí ponemos la página donde se direcciona cuando hacemos login
            //Garantizamos que antes de PINTAR la ReservarEspacioPage,estamos estableciendo la ReservarEspacioViewModel
            MainViewModel.GetInstance().ReservarEspacio = new ReservarEspacioViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ReservarEspacioPage());
            

        }
        #endregion
    }
}
