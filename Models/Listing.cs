using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Zilhome_Server.Models
{
    [BsonIgnoreExtraElements]
    public class Listing
    {
        [BsonElement("Listing_id")]
        [JsonProperty("Listing_id")]
        public string ListingId { get; set; }
        [JsonProperty("Price")]
        public int Price { get; set; }
        
        [JsonProperty("Details")]
        public Details Details { get; set; }

        [JsonProperty("Address")]
        public Address Address { get; set; }

        [JsonProperty("Zestimate")]
        public bool Zestimate { get; set; }

        [JsonProperty("Agent")]
        public bool Agent { get; set; }

        [JsonProperty("Saved")]
        public bool Saved { get; set; }


    }

    public class Details
    {
        [BsonElement("Room_count")]
        [JsonProperty("Room_count")]
        public int RoomCount { get; set; }

        [BsonElement("Bathroom_count")]
        [JsonProperty("Bathroom_count")]
        public int BathroomCount { get; set; }

        [JsonProperty("Square_footage")]
        [BsonElement("Square_footage")]
        public int SquareFootage { get; set; }
    }

    public class Address
    {
        [JsonProperty("House_number")]
        public int House_number { get; set; }
        
        [JsonProperty("Street_number")]
        public int Street_number { get; set; }

        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("ZIP_code")]
        public int ZIP_code { get; set; }
    }
}
