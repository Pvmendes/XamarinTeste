using System;
using IndoorTeste.Helpers;
using SQLite;

namespace IndoorTeste.Models
{
    public class BaseDataObject : ObservableObject
    {
        public BaseDataObject()
        {
           //Id = Guid.NewGuid().ToString();
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        public DateTimeOffset CreatedAt { get; set; }
        
        public DateTimeOffset UpdatedAt { get; set; }
        
        public string AzureVersion { get; set; }
    }
}
