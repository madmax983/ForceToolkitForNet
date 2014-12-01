namespace Salesforce.Tooling.Models
{
    public class Layout
    {
        public const string SObjectTypeName = "Layout";

        public string Id { get; set; }
        public string FullName { get; set; }
        public object Metadata { get; set; }
        public string Name { get; set; }
        public string NamespacePrefix { get; set; }
        public string ShowSubmitAndAttachButton { get; set; }
        public string TableEnumOrId { get; set; } 
    }
}
