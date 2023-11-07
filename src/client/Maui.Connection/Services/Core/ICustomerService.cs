using Maui.Connection.Models;

namespace Maui.Connection.Services.Core;

public interface ICustomerService
{
    Customer GetById(Guid id);
}