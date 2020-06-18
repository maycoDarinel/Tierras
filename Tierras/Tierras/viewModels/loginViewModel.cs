



namespace Tierras.viewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class loginViewModel : BaseViewModel
    {
        #region Eventos


        #endregion

        #region Atributos

        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Email 
        {
            get
            {
                return this.email;
            }
            set
            {
                SetValue(ref this.email, value);
            }
        }
        public string Password 
        {  
            get 
            { 
                return this.password; 
            }
            set 
            { 
                SetValue(ref this.password, value);
            }
        }

        public bool IsRemembered { get; set; }

        public bool IsRunning {
            get
            {
                return this.isRunning ;
            }
            set
            {
                SetValue(ref this.isRunning , value);
            }
        }
        public bool IsEnabled {
            get
            {
                return this.isEnabled ;
            }
            set
            {
                SetValue(ref this.isEnabled , value);
            }
        }


        #endregion

        #region Constructor
        public loginViewModel ()

        {
            this.IsRemembered = true;
            this.IsEnabled = true;

            this.Email = "maycodarinel@gmail.com";
            this.Password = "1234";
            
        }

        #endregion

        #region Commands
        public ICommand LoginCommand
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
                      "Ingrese un correo",
                      "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))

            {
                await Application.Current.MainPage.DisplayAlert(
                      "Error",
                      "Ingrese una contraseña",
                      "Aceptar");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Email != "maycodarinel@gmail.com" || this.Password != "1234")

            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                      "Error",
                      "Correo o Contraseña incorrecta",
                      "Aceptar");
                this.Password = string.Empty;

                return;
            }


            this.IsRunning = false;
            this.IsEnabled = true;

            this.Email = string.Empty;
            this.Password = string.Empty;

            MainViewModel.GetIntance().Tierras = new TierrasViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new TierrasPage());
            
            


        }
        #endregion
    }
}
