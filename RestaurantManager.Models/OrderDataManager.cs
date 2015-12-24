using System.Collections.Generic;


namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        
        protected override void OnDataLoaded()

        {

   
            this.MenuItems = base.Repository.StandardMenuItems;
            this.OnPropertyChanged("MenuItems");

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
            this.OnPropertyChanged("CurrentlySelectedMenuItems");
        }
        

        public List<MenuItem> MenuItems
        {
            get;
            set; 
        }

        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get;
            set; 
        }  
           
       
    }
}
