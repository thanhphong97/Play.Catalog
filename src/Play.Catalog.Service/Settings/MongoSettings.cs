namespace Play.Catalog.Service.Settings
{
    public class MongoSettings
    {
        public string Host { get; init; }
        public string Port { get; init; }
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}