using System;
namespace Salesforce.Tooling.Models
{
    public class ApexTestResult
    {
        public const string SObjectTypeName = "ApexTestResult";

        public string Id { get; set; }
        public string ApexClassId { get; set; }
        public string ApexLogId { get; set; }
        public string AsyncApexJobId { get; set; }
        public string Message { get; set; }
        public string MethodName { get; set; }
        public string Outcome { get; set; }
        public string QueueItemId { get; set; }
        public string StackTrace { get; set; }
        public string TestTimestamp { get; set; }
    }
}
