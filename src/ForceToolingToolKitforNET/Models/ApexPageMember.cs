using System;

namespace Salesforce.Tooling.Models
{
    public class ApexPageMember
    {
        public const string SObjectTypeName = "ApexPageMember";

        public string Id { get; set; }
        public string FullName { get; set; }
        public string Body { get; set; }
        public string Content { get; set; }
        public string ContentEntityId { get; set; }
        public DateTime LastSyncDate { get; set; }
        public object Metadata { get; set; }
        public string MetadataContainerId { get; set; }
    }
}
