namespace Salesforce.Tooling.Models
{
    public class StaticResource
    {
        public const string SObjectTypeName = "StaticResource";

        public string Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public string ContentType { get; set; }
        public string CacheControl { get; set; }
    }
}
