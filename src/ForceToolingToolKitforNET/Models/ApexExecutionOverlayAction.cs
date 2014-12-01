using System;

namespace Salesforce.Tooling.Models
{
    public class ApexExecutionOverlayAction
    {
        public const string SObjectTypeName = "ApexExecutionOverlayAction";

        public string Id { get; set; }
        public string ActionScript { get; set; }
        public string ActionScriptType { get; set; }
        public string ExecutableEntityId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsDumpingHeap { get; set; }
        public object Metadata { get; set; }
        public int Iteration { get; set; }
        public int Line { get; set; }
        public string ScopeId { get; set; }
    }
}
