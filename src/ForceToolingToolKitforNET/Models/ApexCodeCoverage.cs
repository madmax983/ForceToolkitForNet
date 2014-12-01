namespace Salesforce.Tooling.Models
{
    public class ApexCodeCoverage
    {
        public const string SObjectTypeName = "ApexCodeCoverage";

        public string Id { get; set; }
        public string ApexTestClassId { get; set; }
        public string TestMethodName { get; set; }
        public string ApexClassorTriggerId { get; set; }
        public int NumLinesCovered { get; set; }
        public int NumLinesUncovered { get; set; }
        public object coverage { get; set; }
    }
}
