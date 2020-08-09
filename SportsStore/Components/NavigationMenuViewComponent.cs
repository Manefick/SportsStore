using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IProductRepository repository;
        public NavigationMenuViewComponent(IProductRepository rep)
        {
            repository = rep;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Products.Select(p => p.Category).Distinct().OrderBy(x => x));
        }
    }
}
