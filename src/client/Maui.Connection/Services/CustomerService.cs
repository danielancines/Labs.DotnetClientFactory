using Maui.Connection.Models;
using Maui.Connection.Services.Core;

namespace Maui.Connection.Services;

public class CustomerService : ICustomerService
{
    private readonly HttpClient _httpClient;

    #region Constructor

    public CustomerService(HttpClient httpClient)
    {
        this._httpClient = httpClient;
    }

    #endregion
    #region Public Methods

    public Customer GetById(Guid id)
    {
        return new Customer();
    }

    #endregion
}