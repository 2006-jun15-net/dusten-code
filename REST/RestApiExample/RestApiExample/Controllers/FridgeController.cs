using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApiExample.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApiExample.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class FridgeController : ControllerBase {

        private static List<FoodItem> mItems = new List<FoodItem> {

            new FoodItem {

                Id = 1,
                Name = "Milk",
                ExpirationDate = new DateTime (2020, 6, 15)
            },

            new FoodItem {

                Id = 2,
                Name = "Cheese",
                ExpirationDate = new DateTime (2020, 8, 15)
            },

            new FoodItem {

                Id = 3,
                Name = "Sausage",
                ExpirationDate = new DateTime (2021, 7, 15)
            }
        };

        [HttpGet("items")]
        public IEnumerable<FoodItem> GetItems () {
            return mItems;
        }

        [HttpGet ("items/{id}")]
        public FoodItem GetItem (int id) {
            return mItems.Where (f => f.Id == id).First ();
        }


        [HttpPost ("items")]
        public void PostItems ([FromBody] FoodItem value) {
            mItems.Add (value);
        }

        [HttpPost ("items/clean")]
        public void PostCleanItems () {
            mItems.RemoveAll (f => f.ExpirationDate <= DateTime.Now);
        }


        [HttpPut ("items/{id}")]
        public void PutItem (int id, [FromBody] FoodItem value) {
            mItems.Where (f => f.Id == id).First ().Name = value.Name;
        }


        [HttpDelete ("items/{id}")]
        public void DeleteItem (int id) {
            mItems.RemoveAll (f => f.Id == id);
        }
    }
}
