namespace Salesforce.Tooling.Models
{
    public class DeployDetails
    {
        public const string SObjectTypeName = "DeployDetails";

        public string Id { get; set; }
        public string componentFailures { get; set; }
    }
}
