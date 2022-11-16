using Microsoft.VisualBasic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotificationSystemDanske.Entity
{
    public class Company
    {
        public int Id { get; set; }
        public string Entity_Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Market { get; set; } = string.Empty;

        public Company(Company company)
        {
 
        }

    }
}
