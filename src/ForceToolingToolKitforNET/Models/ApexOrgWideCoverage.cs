namespace Salesforce.Tooling.Models
{
    public class ApexOrgWideCoverage
    {
        public const string SObjectTypeName = "ApexOrgWideCoverage";

        public string Id { get; set; }
        public int PercentCovered { get; set; }
    }
}
