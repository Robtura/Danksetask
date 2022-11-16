using Microsoft.VisualBasic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotificationSystemDanske.Entity
{
    public class Company
    {
        public int Id { get; set; }
        public string Entity_Id { get; set; }
        public string Name { get; set; } 
        public string Number { get; set; } 
        public string Type { get; set; } 
        public string Market { get; set; }

        /*public Company(int id, string entity_id, string name, string number, string type, string market)
        {
            this.Id = id;
            this.Entity_Id = entity_id;
            this.Name = name;
            this.Number = number;
            this.Type = type;
            this.Market = market;
        }*/

        /*public Company(Company company)
        {
            this.Id = company.Id;
            this.Entity_Id = company.entity_id;
            this.Name = company.name;
            this.Number = company.number;
            this.Type = company.type;
            this.Market = company.market;
        }*/
    }
}
