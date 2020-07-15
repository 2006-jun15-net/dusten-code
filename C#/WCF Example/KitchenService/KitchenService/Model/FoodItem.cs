using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace KitchenService.Model {

    [DataContract]
    public class FoodItem {

        [DataMember]
        public int Id { get; set;  }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime ExpirationDate { get; set; }
    }
}