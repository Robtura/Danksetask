using Microsoft.VisualBasic;

namespace NotificationSystemDanske.Entity
{
    public class Company
    {
        public int Id { get; set; }
        public string? Entity_Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public Type Type { get; set; }
        public Market Market { get; set; }
    }

    public enum Type
    {
        small, medium, large, corporate
    }

    public enum Market
    {
        Denmark, Norway, Sweden, Finland
    }
}
