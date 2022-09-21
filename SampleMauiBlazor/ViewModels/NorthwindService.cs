using Microsoft.AspNetCore.Components;
using Radzen;

namespace SampleMauiBlazor.ViewModels
{
    public  class NorthwindService
    {
        [Inject]
        public static NavigationManager _navigationManager { get; set; }

        public NorthwindService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }
    }
}
