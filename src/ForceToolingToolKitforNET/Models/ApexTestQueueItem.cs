namespace Salesforce.Tooling.Models
{
    public class ApexTestQueueItem
    {
        public const string SObjectTypeName = "ApexTestQueueItem";

        public string Id { get; set; }
        public string ApexClassId { get; set; }
        public string Status { get; set; }
        public string ExtendedStatus { get; set; }
        public string ParentJobId { get; set; }
    }
}
