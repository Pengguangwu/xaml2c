using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            
         this.OrderItems = base.Repository.Orders;
 
        }

        public List<Order> OrderItems
        {
            get { return base.Repository.Orders; }
            set { OnPropertyChanged(); }
        }
        
    }
}
