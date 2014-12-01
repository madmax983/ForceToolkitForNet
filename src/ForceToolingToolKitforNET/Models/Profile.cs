namespace Salesforce.Tooling.Models
{
    public class Profile
    {
        public const string SObjectTypeName = "Profile";

        public string Id { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
        public object Metadata { get; set; }
        public string Name { get; set; }
    }
}
