
namespace Tierras.viewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Models;
    using Services;
    using Xamarin.Forms;

    public class TierrasViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private ObservableCollection<Tierra> tierras;
        #endregion

        #region Properties
        public ObservableCollection<Tierra> Tierras
        {
            get { return this.tierras; }
            set { SetValue(ref this.tierras, value); }
        }
        #endregion
       
        #region Constructors
        public TierrasViewModel()
        {
            this.apiService = new ApiService();
            this.LoadLands();
            
           
        }
        #endregion

        #region Methods
        private async void LoadLands()
        {
            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    connection.Message,
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }
      
            var response = await this.apiService.GetList<Tierra>(
                "https://restcountries.eu",
                "/rest",
                "/v2/all");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Acceptar");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }

            var list = (List<Tierra>)response.Result;
            this.Tierras = new ObservableCollection<Tierra>(list);
        }
        #endregion
    }
}
