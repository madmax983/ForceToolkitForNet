namespace Salesforce.Tooling.Models
{
    public class ApexTriggerMember
    {
        public const string SObjectTypeName = "ApexTriggerMember";

        public string Id { get; set; }
        public string FullName { get; set; }
        public string Body { get; set; }
        public string Content { get; set; }
        public string ContentEntityId { get; set; }
        public string LastSyncDate { get; set; }
        public object Metadata { get; set; }
        public string MetadataContainerId { get; set; }
        public SymbolTable symbolTable { get; set; }
    }
}
