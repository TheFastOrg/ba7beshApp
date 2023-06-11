using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bahbashApp
{
    public class GlobalSetting
    {
        public const string BackendEndpointURL = "http://YOUR_IP_OR_DNS_NAME";

        private string _backendEndpoint;
        public GlobalSetting()
        {
            AuthToken = "INSERT AUTHENTICATION TOKEN";

            BackendEndpoint = BackendEndpointURL;
        }
        public static GlobalSetting Instance { get; } = new GlobalSetting();

        public string BackendEndpoint
        {
            get => _backendEndpoint;
            set
            {
                _backendEndpoint = value;
            }
        }
        public string AuthToken { get; set; }

    }
}
