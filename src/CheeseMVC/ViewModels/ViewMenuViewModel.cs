using CheeseMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CheeseMVC.ViewModels
{
    public class ViewMenuViewModel
    {
        
        public IList<CheeseMenu> Items { get; set; }
        public Menu Menu { get; set; }
        //public ViewMenuViewModel()
        //{ }

        //public ViewMenuViewModel(Menu menu, IList<CheeseMenu> items)
        /*{
            Menu = menu;
            Items = items;
        }
        */
    }
}
