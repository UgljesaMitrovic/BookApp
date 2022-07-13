using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BookApp
{
    public class Meta
    {
        [JsonPropertyName("states")]
        public List<String> States { get; set; }
    }
}
