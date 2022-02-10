using System;
using System.Collections.Generic;
using TestBugCollectionView.ViewModels;
using TestBugCollectionView.Views;
using Xamarin.Forms;

namespace TestBugCollectionView
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

            Routing.RegisterRoute($"home/{nameof(ItemsPage)}", typeof(ItemsPage));
        }

    }
}
