using Prism.Navigation;
using PrismEventNavRepro.Models;

namespace PrismEventNavRepro.ViewModels
{
    public class AuthorDetailPageViewModel : ViewModelBase
    {
        public AuthorDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public Author Author { get; set; }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Author = (Author) parameters["author"];
        }
    }
}
