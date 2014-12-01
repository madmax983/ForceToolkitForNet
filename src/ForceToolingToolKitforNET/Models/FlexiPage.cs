namespace Salesforce.Tooling.Models
{
    public class FlexiPage
    {
        public const string SObjectTypeName = "FlexiPage";

        public string Id { get; set; }
        public string Description { get; set; }
        public string DeveloperName { get; set; }
        public string FullName { get; set; }
        public string MasterLabel { get; set; }
        public string Type { get; set; }
        public object Metadata { get; set; }
        public string NamespacePrefix { get; set; }
    }
}
