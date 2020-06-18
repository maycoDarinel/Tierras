 //video 7
namespace Tierras.viewModels
{

    public class MainViewModel
    {
        #region ViewModels
        public loginViewModel Login 
        {
            get;
            set; 
        }

        public TierrasViewModel Tierras 
        { 
            get; 
            set; 
        }
        #endregion
        #region Constructors
        public MainViewModel()
        {
            this.Login = new loginViewModel();
        }
        #endregion

        #region Singleton 
        // nos permite hacer un llamado  de mainViewModel sin llamar a otra clase
        private static MainViewModel instance; // propiedad privada
        public static MainViewModel GetIntance( )//metodo estatico 
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;

        }



        #endregion

        // http://restcountries.eu/rest/v2/all
    }
}
