﻿



namespace Tierras.viewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    public class loginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string password { get; set; }

        public bool IsRemembered { get; set; }

        public bool IsRunning { get; set; }


        #endregion

        #region Constructor
        public loginViewModel ()

        {
            this.IsRemembered = true;
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

        private void Login()
        {
            
        }
        #endregion
    }
}
