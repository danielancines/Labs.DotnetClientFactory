using Maui.Connection.Models;
using Maui.Connection.Services.Core;

namespace Maui.Connection.Services;

public class CustomerService : ICustomerService
{
    #region Public Methods

    public Customer GetById(Guid id)
    {
        return new Customer();
    }

    #endregion
}