using System;

namespace Salesforce.Tooling.Models
{
    public class ApexExecutionOverlayResult
    {
        public const string SObjectTypeName = "ApexExecutionOverlayResult";

        public string Id { get; set; }
        public string ActionScript { get; set; }
        public ApexResult apexResult { get; set; }
        public DateTime ExpirationDate { get; set; }
        public HeapDump heapDump { get; set; }
        public bool IsDumpingHeap { get; set; }
        public int Iteration { get; set; }
        public int Line { get; set; }
        public SOQLResult soqlResult { get; set; }
        public string UserId { get; set; }
    }
}
