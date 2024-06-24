using System.Collections.Generic;

namespace patrones.Proxy
{
    public interface IRepository
    {
        IList<Customer> GetAll();
        void Save(Customer customer);
    }
}
