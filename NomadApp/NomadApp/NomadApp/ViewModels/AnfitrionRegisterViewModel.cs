namespace NomadApp.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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
    }
}
