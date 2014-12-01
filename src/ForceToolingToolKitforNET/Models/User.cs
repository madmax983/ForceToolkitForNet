namespace Salesforce.Tooling.Models
{
    public class User
    {
        public const string SObjectTypeName = "User";

        public string Id { get; set; }
        public string Username { get; set; }
        public string WorkspaceId { get; set; }
    }
}
