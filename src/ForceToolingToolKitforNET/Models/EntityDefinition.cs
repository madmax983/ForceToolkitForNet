namespace Salesforce.Tooling.Models
{
    public class EntityDefinition
    {
        public const string SObjectTypeName = "EntityDefinition";

        public string Id { get; set; }
        public string DefaultCompactLayoutId { get; set; }
        public string DeveloperName { get; set; }
        public string DurableId { get; set; }
        public string FullName { get; set; }
        public bool IsApexTriggerable { get; set; }
        public bool IsCompactLayoutable { get; set; }
        public bool IsCustomizable { get; set; }
        public bool IsWorkflowEnabled { get; set; }
        public string Label { get; set; }
        public string MasterLabel { get; set; }
        public object Metadata { get; set; }
        public string NamespacePrefix { get; set; }
        public string PluralLabel { get; set; }
        public string QualifiedApiName { get; set; }
    }
}
