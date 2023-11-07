using Maui.Connection.Services.Core;
using Maui.Domain.Contracts;

namespace Maui.Domain.ViewModels;

public class MainPageViewModel : IMainPageViewModel
{
    private readonly ICustomerService _customerService;

    public MainPageViewModel(ICustomerService customerService)
    {
        _customerService = customerService;
    }
}