﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BookApp
{
    public class RootObject
    {
        [JsonPropertyName("books")]
        public List<Book> Books { get; set; }

    }
}
