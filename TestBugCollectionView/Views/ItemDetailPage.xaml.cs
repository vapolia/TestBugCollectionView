using System.ComponentModel;
using TestBugCollectionView.ViewModels;
using Xamarin.Forms;

namespace TestBugCollectionView.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}