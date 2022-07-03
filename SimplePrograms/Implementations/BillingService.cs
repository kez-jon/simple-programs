using SimplePrograms.Interfaces;
using SimplePrograms.Models;

namespace SimplePrograms.Implementations
{
    public class BillingService : IBillingService
    {
        public decimal Calcualte(List<Product> products)
        {
            return products.Sum(i => i.Price);
        }
    }
}
