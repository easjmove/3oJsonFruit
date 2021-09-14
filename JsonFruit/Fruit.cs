using System;
using System.Text.Json.Serialization;

namespace JsonFruit
{
    public class Fruit
    {
        [JsonPropertyName("TypeOfFruit")]
        public string typeOfFruit { get; set; }

        [JsonIgnore]
        public string secretInfo;

        public Fruit()
        {
        }

        public Fruit(string typeOfFruit)
        {
            this.typeOfFruit = typeOfFruit;
        }
    }
}
