

namespace Tierras.Infrastructure
{
    using viewModels;
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main  
        { 
            get; 
            set; 
        }

        #endregion

        #region Constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }

#endregion
    }
}
