using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Yolo.Domain
{
    public class Label
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("category")]
        public string Name { get; set; }
        [JsonPropertyName("super_category")]
        public string Category { get; set; }
    }
}
