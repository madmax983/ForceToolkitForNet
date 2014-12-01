namespace Salesforce.Tooling.Models
{
    public class WorkflowAlert
    {
        public const string SObjectTypeName = "WorkflowAlert";

        public string Id { get; set; }
        public string CcEmails { get; set; }
        public string Description { get; set; }
        public string DeveloperName { get; set; }
        public string EntityDefinitionId { get; set; }
        public string FullName { get; set; }
        public object Metadata { get; set; }
        public string NamespacePrefix { get; set; }
        public string SenderType { get; set; }
        public string TableEnumOrId { get; set; }
        public string TemplateId { get; set; }
    }
}
