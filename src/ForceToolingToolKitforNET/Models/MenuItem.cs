namespace Salesforce.Tooling.Models
{
    public class MenuItem
    {
        public const string SObjectTypeName = "MenuItem";

        public string Id { get; set; }
        public bool Active { get; set; }
        public string AppId { get; set; }
        public string Color { get; set; }
        public string IconURL { get; set; }
        public string Label { get; set; }
        public string MenuType { get; set; }
        public int SortOrder { get; set; }
        public string Theme { get; set; }
    }
}
