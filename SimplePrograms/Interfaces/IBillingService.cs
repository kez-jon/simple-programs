using SimplePrograms.Models;

namespace SimplePrograms.Interfaces
{
    public interface IBillingService
    {
        decimal Calcualte(List<Product> products);
    }
}
