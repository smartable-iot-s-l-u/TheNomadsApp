namespace NomadApp.ViewModels
{
    using GalaSoft.MvvmLight.Command;
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
        public ICommand LoginCommand => new RelayCommand(Login); //Le sacamos el command del Login


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



            //Quemamos la contraseña
            if (this.Email != "jordivr77@gmail.com" || this.Password != "1234")
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email o Password incorrecto.",
                    "Aceptar");
                this.Password = string.Empty; //Vaciamos el campo del password
                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                    "OK",
                    "Maravilloso.",
                    "Aceptar");
            return;

        }
        #endregion
    }
}
