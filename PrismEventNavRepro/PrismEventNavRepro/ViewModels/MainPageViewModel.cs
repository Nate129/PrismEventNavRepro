using System.Collections.ObjectModel;
using Prism.Navigation;
using PrismEventNavRepro.Models;

namespace PrismEventNavRepro.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";

            Authors = new ObservableCollection<Author>
            {
                new Author {Name = "John Doe"},
                new Author {Name = "Jane Doe"}
            };
        }

        public ObservableCollection<Author> Authors { get; set; }
    }
}
