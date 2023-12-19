using ExamenParcial2.ViewModels;

namespace ExamenParcial2.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginPageViewModel loginPageViewModel)
    {
		InitializeComponent();
        BindingContext = loginPageViewModel;
    }
}