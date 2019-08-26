using System;
using System.Collections.Generic;

namespace DataBase.Models
{
    public class Stylist
    {
        
        public string Name { get; set; }
        public List<Client> Clients { get; set; }
        public string Specialty { get; set; }
        public int StylistId { get; set; }
    }
}