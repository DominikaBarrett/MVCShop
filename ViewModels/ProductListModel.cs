using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.ViewModels
{
    public class ProductListModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory{ get; set; }
    }
}
