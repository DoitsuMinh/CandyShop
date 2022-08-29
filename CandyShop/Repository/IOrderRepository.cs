using CandyShop.Models;

namespace CandyShop.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
