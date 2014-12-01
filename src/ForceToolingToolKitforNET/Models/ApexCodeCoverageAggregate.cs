namespace Salesforce.Tooling.Models
{
    public class ApexCodeCoverageAggregate
    {
        public const string SObjectTypeName = "ApexCodeCoverageAggregate";

        public string Id { get; set; }
        public string ApexClassorTriggerId { get; set; }
        public int NumLinesCovered { get; set; }
        public int NumLinesUncovered { get; set; }
        public object coverage { get; set; }
    }
}
