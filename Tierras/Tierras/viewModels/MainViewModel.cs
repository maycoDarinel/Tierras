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


        #endregion
        #region Constructors
        public MainViewModel()
        {
            this.Login = new loginViewModel();
        }
        #endregion
    }
}
