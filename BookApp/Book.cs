using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BookApp
{
    public class Book
    {
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }


        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }


        [JsonPropertyName("parent_name")]
        public string ParentName { get; set; }


    }
}
