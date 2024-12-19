using expensebuddy.Models;
using expensebuddy.PageModels;

namespace expensebuddy.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}