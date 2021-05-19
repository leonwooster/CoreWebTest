using System.ComponentModel.DataAnnotations;
using CoreWebTest.Attributes;

namespace CoreWebTest.Models
{
    public class TodoItem
    {
        public string Country { get; set; }
        public int Id { get; set; }
        [CountryBasedDisplayName("VN")]
        public string Name { get; set; }
        public int Priority { get; set; }
        public bool IsDone { get; set; }        
    }
}
