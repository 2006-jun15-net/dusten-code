using System;

namespace RestApiExample.Models {

    public class FoodItem {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
