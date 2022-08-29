using CandyShop.Models;
using System.Collections;
using System.Collections.Generic;

namespace CandyShop.Repository
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandy { get; }
        IEnumerable<Candy> GetCandyOnSale { get; }
        Candy GetCandyById(int ClothId);
    }
}
