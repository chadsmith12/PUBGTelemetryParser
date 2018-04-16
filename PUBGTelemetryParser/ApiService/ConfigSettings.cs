namespace PUBGTelemetryParser.ApiService
{
    /// <summary>
    /// The settings to configure the api with. 
    /// </summary>
    public class ConfigSettings
    {
        /// <summary>
        /// Your PUBG Api Key.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Set this to true to show logs.
        /// </summary>
        public bool Verbose { get; set; }
    }
}
