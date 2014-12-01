namespace Salesforce.Tooling.Models
{
    public class CompactLayout
    {
        public const string SObjectTypeName = "CompactLayout";

        public string Id { get; set; }
        public string DeveloperName { get; set; }
        public string FullName { get; set; }
        public object Metadata { get; set; }
        public string NamespacePrefix { get; set; }
        public string SobjectType { get; set; }
    }
}
