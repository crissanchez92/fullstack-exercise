namespace roofstock.Api
{
    /// <summary>
    /// Maps the section ConfigurationOptions from appsettings.json
    /// </summary>
    public class ConfigurationOptions
    {
        public const string Key = "ConfigurationOptions";
        public string DataSource { get; set; }
    }
}