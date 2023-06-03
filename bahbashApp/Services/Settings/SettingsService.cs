namespace bahbashApp.Services.Settings
{
    public class SettingsService : ISettingsService
	{
        #region Setting Constants

        private const string AccessToken = "access_token";

        #endregion

        #region Settings Properties
        public string AuthAccessToken
        {
            get => SecureStorage.GetAsync(AccessToken).Result;
            set => SecureStorage.SetAsync(AccessToken, value).Wait();
        }
        #endregion
    }
}

