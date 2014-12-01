namespace Salesforce.Tooling.Models
{
    public class SOQLResult
    {
        public const string SObjectTypeName = "SOQLResult";

        public string Id { get; set; }
        public string queryError { get; set; }
        public object queryMetadata { get; set; }
        public object[] queryResult { get; set; }
    }
}
