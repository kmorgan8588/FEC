# FEC
Retooled an old project from Node.js/Express to C#/ASP.NET

# Controllers
 - ListingsController
 
 Handles the major API route for Listings
 api/listings
  - GET / - returns the full json object containing all listings from the mongo Database
  - GET /:ListingId - returns the json object containing the listing matching the id or NotFound if the resource doesn't exist
    
# Models
  - Listing
  - Details
  - Address
  - ZilhomeServerDatabaseSettings
  
  Handles the mapping from the mongoDB page to class objects for use in the ListingsController
   -  [BsonElement("Name")] - refers to the mongodb property name
   -  [JsonProperty("Name")] - renames when sending the Model as json
    
   In order to match the nested format of the mongodb object, I had to make classes Details and Address to mimic the same effect within Listing
   
   ZilhomeServerDatabaseSettings handles setting the appropriate database settings from appsettings.json for use in building the connection to the database
   
   
# Services
  - ListingService
  
  Houses all the different methods used after connecting to the database using Listing.cs Model
  Includes all CRUD operations for interacting with the database for use in the ListingsController Routes Methods
