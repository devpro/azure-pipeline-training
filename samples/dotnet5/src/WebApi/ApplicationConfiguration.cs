using Microsoft.Extensions.Configuration;

namespace Dotnet5Sample.WebApi
{
    public class ApplicationConfiguration
    {
        private readonly IConfiguration _configuration;

        public ApplicationConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ApplicationTitle => _configuration.GetValue<string>("Application:Title");

        public string ApplicationVersion => _configuration.GetValue<string>("Application:Version");
    }
}
