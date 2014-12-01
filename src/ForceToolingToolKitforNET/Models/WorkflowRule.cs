namespace Salesforce.Tooling.Models
{
    public class WorkflowRule
    {
        public const string SObjectTypeName = "WorkflowRule";

        public string Id { get; set; }
        public string FullName { get; set; }
        public object Metadata { get; set; }
        public string Name { get; set; }
        public string NamespacePrefix { get; set; }
        public string TableEnumOrId { get; set; }
    }
}
