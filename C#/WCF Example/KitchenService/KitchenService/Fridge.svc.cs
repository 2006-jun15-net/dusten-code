using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitchenService.Model {

    public class Fridge : IFridge {

        private List<FoodItem> mContents = new List<FoodItem> {

            new FoodItem {
                Id = 1,
                Name = "Cheese",
                ExpirationDate = new DateTime (2020, 6, 14)
            },

            new FoodItem {
                Id = 2,
                Name = "Milk",
                ExpirationDate = new DateTime (2020, 8, 14)
            }
        };

        public ICollection<FoodItem> GetAllItems () {
            return mContents.ToHashSet ();
        }

        public ICollection<FoodItem> Clean () {
            
            var expired = mContents.Where (i => i.ExpirationDate < DateTime.Now).ToList ();

            return expired.ToHashSet ();
        }
    }
}