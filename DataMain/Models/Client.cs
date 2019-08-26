using System.Collections.Generic;

namespace DataBase.Models
{
    public class Client
    {
        public string Name { get; set; }
         public string Description { get; set; }
        public string Stylist { get; set; }
        public int StylistId { get; set; }
        public int ClientId { get; set; }
    }
}