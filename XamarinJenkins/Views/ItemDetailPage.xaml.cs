using System.ComponentModel;
using Xamarin.Forms;
using XamarinJenkins.ViewModels;

namespace XamarinJenkins.Views
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