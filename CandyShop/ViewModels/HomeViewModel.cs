using CandyShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace CandyShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Candy> CandyOnSale { get; set; }
    }
}
