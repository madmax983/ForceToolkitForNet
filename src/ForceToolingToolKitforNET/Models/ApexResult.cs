namespace Salesforce.Tooling.Models
{
    public class ApexResult
    {
        public const string SObjectTypeName = "ApexResult";

        public string Id { get; set; }
        public string apexError { get; set; }
        public object apexExecutionResult { get; set; }
    }
}
