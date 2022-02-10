using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TestBugCollectionView.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestBugCollectionView.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public List<GroupViewModel> Items { get; }
        public ICommand TapHeaderCommand { get; }
        public ICommand SelectItemCommand { get; }

        public AboutViewModel()
        {
            Title = "About";

            Items = new()
            {
                new(10, new ItemViewModel[]
                {
                    new() { ItemId = 11 },
                    new() { ItemId = 12 },
                    new() { ItemId = 13 },
                }),
                new(20, new ItemViewModel[]
                {
                    new() { ItemId = 21 },
                    new() { ItemId = 22 },
                    new() { ItemId = 23 },
                }),
            };

            TapHeaderCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync(nameof(ItemsPage));
            });

            SelectItemCommand = new Command<ItemViewModel>(async selectedItem =>
            {
                await Shell.Current.GoToAsync(nameof(ItemsPage));
            });
        }
    }


    public class ItemViewModel
    {
        public int ItemId { get; set; }
    }

    public class GroupViewModel : ObservableCollection<ItemViewModel>
    {
        public int GroupId { get; set; }

        public GroupViewModel(int groupId, IEnumerable<ItemViewModel> items) : base(items)
        {
            GroupId = groupId;
        }
    }
}
