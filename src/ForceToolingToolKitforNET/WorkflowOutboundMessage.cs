namespace Salesforce.Tooling
{
    public class WorkflowOutboundMessages
    {
        public const string SObjectTypeName = "WorkflowOutboundMessages";

        public string Id { get; set; }
        public string ApiVersion { get; set; }
        public string EntityDefinitionId { get; set; }
        public string FullName { get; set; }
        public string IntegrationUserId { get; set; }
        public object Metadata { get; set; }
        public string Name { get; set; }
        public string NamespacePrefix { get; set; }
        public string SourceTableEnumOrId { get; set; }
    }
}
