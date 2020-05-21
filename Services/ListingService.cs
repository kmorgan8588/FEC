using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Zilhome_Server.Models;

namespace Zilhome_Server.Services
{
    public class ListingService
    {
        private readonly IMongoCollection<Listing> _houses;

        public ListingService(IZilhomeServerDatabaseSettings settings)
        {
            Console.WriteLine(settings);
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _houses = database.GetCollection<Listing>(settings.HouseCollectionName);
        }

        public List<Listing> Get() =>
            _houses.Find(house => true).ToList();

        public Listing Get(string id) =>
            _houses.Find<Listing>(house => house.ListingId == id).FirstOrDefault();

        public Listing Create(Listing listing)
        {
            _houses.InsertOne(listing);
            return listing;
        }

        public void Update(string id, Listing change) =>
            _houses.ReplaceOne(house => house.ListingId == id, change);

        public void Remove(Listing listing) =>
            _houses.DeleteOne(house => house.ListingId == listing.ListingId);

        public void Remove(string id) =>
            _houses.DeleteOne(listing => listing.ListingId == id);
    }
}
