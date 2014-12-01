namespace Salesforce.Tooling.Models
{
    public class ProfileLayout
    {
        public const string SObjectTypeName = "ProfileLayout";

        public string Id { get; set; }
        public string LayoutId { get; set; }
        public string ProfileId { get; set; }
        public string RecordTypeId { get; set; }
        public string TableEnumOrId { get; set; }
    }
}
