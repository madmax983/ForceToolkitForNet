namespace Salesforce.Tooling.Models
{
    public class RecordType
    {
        public const string SObjectTypeName = "RecordType";

        public string Id { get; set; }
        public string Description { get; set; }
        public string EntityDefinitionId { get; set; }
        public string FullName { get; set; }
        public object Metadata { get; set; }
        public string Name { get; set; }
        public string NamespacePrefix { get; set; }
        public string SobjectType { get; set; }
    }
}
