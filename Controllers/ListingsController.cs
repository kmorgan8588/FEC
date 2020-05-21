using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zilhome_Server.Models;
using Zilhome_Server.Services;

namespace Zilhome_Server.Controllers
{
    [Route("api/listings")]
    //[EnableCors("ReactPolicy")]

    public class ListingsController : ControllerBase
    {
        private readonly ListingService _listingService;

        public ListingsController(ListingService listingService)
        {
            _listingService = listingService;
        }
        [HttpGet]
        public ActionResult<List<Listing>> Get() =>
            _listingService.Get();

        [HttpGet("{Listing_id:length(3)}", Name = "GetHouse")]
        public ActionResult<List<Listing>> Get(string Listing_id)
        {
            List<Listing> Houses = new List<Listing>();
            var house = _listingService.Get(Listing_id);
            Houses.Add(house);
            if (house == null)
            {
                return NotFound();
            }

            return Houses;
        }
    }
}
