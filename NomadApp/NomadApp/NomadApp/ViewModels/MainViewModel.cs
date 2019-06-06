namespace NomadApp.ViewModels
{
    //La hemos de ligar con la (LoginPage) o la PrincipalPage en nuestro caso
    public class MainViewModel
    {
        #region ViewModel
        public PrincipalViewModel Principal
        {
            get;
            set;
        }

        public Anfitrion1aViewModel Anfitrion1A
        {
            get;
            set;
        }

        public Particular1bViewModel Particular1B
        {
            get;
            set;
        }

        public AnfitrionRegisterViewModel AnfitrionRegister
        {
            get;
            set;
        }

        public LoginNomada2ViewModel LoginNomada2
        {
            get;
            set;
        }

        public ReservarEspacioViewModel ReservarEspacio
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Principal = new PrincipalViewModel();
        }
        #endregion

        #region Singleton
        //Nos va a permitir hacer un llamado de la MainViewModel desde CUALQUIER CLASE
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if(instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion
    }
}
