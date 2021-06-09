using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductOnSale { get; set; }
    }
}
