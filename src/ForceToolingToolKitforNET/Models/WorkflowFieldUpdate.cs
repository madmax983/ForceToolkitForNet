namespace Salesforce.Tooling.Models
{
    public class WorkflowFieldUpdates
    {
        public const string SObjectTypeName = "WorkflowFieldUpdates";

        public string Id { get; set; }
        public string EntityDefinitionId { get; set; }
        public string FieldDefinitionId { get; set; }
        public string FullName { get; set; }
        public string LiteralValue { get; set; }
        public string LookupValueId { get; set; }
        public object Metadata { get; set; }
        public string Name { get; set; }
        public string NamespacePrefix { get; set; }
        public string SourceTableEnumOrId { get; set; }
    }
}
