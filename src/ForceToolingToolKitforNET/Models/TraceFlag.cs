using System;

namespace Salesforce.Tooling.Models
{
    public class TraceFlag
    {
        public const string SObjectTypeName = "TraceFlag";

        public string Id { get; set; }
        public string ApexCode { get; set; }
        public string ApexProfiling { get; set; }
        public string Callout { get; set; }
        public string Database { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ScopeId { get; set; }
        public string System { get; set; }
        public string TracedEntityId { get; set; }
        public string Validation { get; set; }
        public string Visualforce { get; set; }
        public string Workflow { get; set; }
    }
}
