using System;
using System.Collections.Generic;
using System.Text;

namespace NomadApp.ViewModels
{
    //La hemos de ligar con la (LoginPage) o la PrincipalPage en nuestro caso
    public class MainViewModel
    {
        #region ViewModel
        public LoginNomada2ViewModel LoginNomada2
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            this.LoginNomada2 = new LoginNomada2ViewModel();
        }
        #endregion  
    }
}
