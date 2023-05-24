using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DemoJsonSerializer02
{
    public class Employee
    {
        [JsonPropertyName("FullName")]
        public string Name { get; set; }
        [JsonIgnore]
        public string Email { get; set; }
        [JsonInclude]
        public decimal Salary { get; set; }
    }
}
