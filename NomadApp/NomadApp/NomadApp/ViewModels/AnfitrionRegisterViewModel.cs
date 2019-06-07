namespace NomadApp.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using GalaSoft.MvvmLight.Helpers;
    using NomadApp.Views;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class AnfitrionRegisterViewModel : BaseViewModel
    {
        //Solo a los que necesito refrescar les pongo la propiedad privada
        #region Attributes
        private string nombre;
        private string email;
        private string password;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Nombre
        {
            get { return this.nombre; }
            set { SetValue(ref this.nombre, value); }
        }
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
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructors
        public AnfitrionRegisterViewModel()
        {
            this.isEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand AnfitrionCommand
        {
            get
            {
                return new RelayCommand(Anfitrion);
            }
        }

        private async void Anfitrion()
        {
            if (string.IsNullOrEmpty(this.Nombre))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes entrar un nombre.",
                    "Aceptar");
                return;
            }

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

            
            this.IsEnabled = false;

            //Quemamos la contraseña
            if (this.Email != "123@gmail.com" || this.Password != "123")
            {
                
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email o Password incorrecto.",
                    "Aceptar");
                this.Password = string.Empty; //Vaciamos el campo del password
                return;
            }

           
            this.IsEnabled = true;

            this.Nombre = string.Empty;
            this.Email = string.Empty;
            this.Password = string.Empty;

            //aquí ponemos la página donde se direcciona cuando hacemos Crear Cuenta
            //Garantizamos que antes de PINTAR la ReservarEspacioPage,estamos estableciendo la ReservarEspacioViewModel
            MainViewModel.GetInstance().CrearCuentaAnfitrion = new CrearCuentaAnfitrionViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new CrearCuentaAnfitrionPage() );


        }
        #endregion
    }
}
