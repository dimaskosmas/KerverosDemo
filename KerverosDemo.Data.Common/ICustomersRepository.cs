using KerverosDemo.Entities;

namespace KerverosDemo.Data.Common
{
    public interface ICustomersRepository
    {
        Customer[] GetCustomers();
    }
}
