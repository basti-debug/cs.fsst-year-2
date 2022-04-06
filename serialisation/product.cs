using System;
using System.Text.Json.Serialization;

namespace serialisation
{
	public class serialisation
	{
        class Product
        {
            [JsonInclude]
            public string Sku { get; set; }

            [JsonInclude]
            public string Name { get; set; }

            [JsonInclude]
            public double Price { get; set; }

            [JsonInclude]
            public string Description { get; set; }

            [JsonIgnore]
            public bool LimitedEdition { get; set; }

        }
    }
}

