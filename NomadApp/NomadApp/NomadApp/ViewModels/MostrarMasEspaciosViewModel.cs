namespace NomadApp.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using NomadApp.Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class MostrarMasEspaciosViewModel : BaseViewModel
    {
        #region Attributes 
        private string name;
        private string email;
        private bool IsEnabled;
        #endregion

        #region Properties
        public string Name
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }

        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        #endregion


        #region Constructors
        public MostrarMasEspaciosViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand RegisterCommand //Le sacamos el command del Login
        {
            get
            {
                return new RelayCommand(Register);
            }
        }

        private async void Register()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes entrar un email.",
                    "Aceptar");
                return;
            }

            this.IsEnabled = false;

            this.Email = string.Empty;


            //aquí ponemos la página donde se direcciona cuando hacemos REGISTRER
            //Garantizamos que antes de PINTAR la ReservarEspacioPage,estamos estableciendo la ReservarEspacioViewModel
            MainViewModel.GetInstance().ListaEspacio = new ListaEspacioViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ListaEspacioPage());


        }
        #endregion
    }

}
