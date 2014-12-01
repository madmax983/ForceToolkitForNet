namespace Salesforce.Tooling.Models
{
    public class FieldDefinition
    {
        public const string SObjectTypeName = "FieldDefinition";

        public string Id { get; set; }
        public string DeveloperName { get; set; }
        public string DurableId { get; set; }
        public string EntityDefinitionId { get; set; }
        public string FullName { get; set; }
        public bool IsCompactLayoutable { get; set; }
        public bool IsWorkflowFilterable { get; set; }
        public string Label { get; set; }
        public string MasterLabel { get; set; }
        public object Metadata { get; set; }
        public string NamespacePrefix { get; set; }
        public string QualifiedApiName { get; set; }
    }
}
