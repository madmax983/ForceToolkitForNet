namespace Salesforce.Tooling.Models
{
    public class SymbolTable
    {
        public const string SObjectTypeName = "SymbolTable";

        public string Id { get; set; }
        public object[] constructors { get; set; }
        public object[] externalReferences { get; set; }
        public object[] innerClasses { get; set; }
        public string[] interfaces { get; set; }
        public object[] methods { get; set; }
        public string name { get; set; }
        public string namespacePrefix { get; set; }
        public object[] properties { get; set; }
        public object[] tableDeclaration { get; set; }
        public object[] variables { get; set; }
    }
}
