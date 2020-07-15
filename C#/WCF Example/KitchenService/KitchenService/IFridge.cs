using KitchenService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KitchenService {

    [ServiceContract]
    interface IFridge {

        [OperationContract]
        ICollection<FoodItem> GetAllItems ();

        [OperationContract]
        ICollection<FoodItem> Clean ();
    }
}
