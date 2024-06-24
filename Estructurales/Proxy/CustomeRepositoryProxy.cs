using System;
using System.Collections.Generic;

namespace patrones.Proxy
{
	public class CustomerRepositoryProxy : IRepository
	{
		IRepository _real;
		Action _createInstanceIfIRepositoryIsNull => () =>
		{
			if (_real == null)
				_real = new CustomerRepository();
		};

		public CustomerRepositoryProxy()
		{
			Session.CanSave = true;
			Session.CanGetAll = true;
		}

		public IList<Customer> GetAll()
		{
			_createInstanceIfIRepositoryIsNull();

			if (Session.CanGetAll) return _real.GetAll();

			throw new UnauthorizedAccessException();
		}

		public void Save(Customer customer)
		{
			_createInstanceIfIRepositoryIsNull();

			if (Session.CanSave)
			{
				_real.Save(customer);
				return;
			}

			throw new UnauthorizedAccessException();
		}
	}
}
