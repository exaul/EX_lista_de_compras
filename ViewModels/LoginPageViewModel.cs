using ExamenParcial2.Models;
using ExamenParcial2.Services.Interfaces;
using CommunityToolkit.Maui.Alerts;
using System.ComponentModel;
using ExamenParcial2.Views;

namespace ExamenParcial2.ViewModels;

public class LoginPageViewModel : INotifyPropertyChanged
{
    private readonly ILoginService loginService;

    public string Usuario { get; set; }
    public string Contraseña { get; set; }
    public Command LoginCommand { get; set; }
    public LoginPageViewModel(ILoginService loginService)
    {
        this.loginService = loginService;
        LoginCommand = new Command(LoginAsync);
        Settings.EmailList = "gustavo@gmail.com,carlos@gmail.com,daniel@gmail.com";
        Settings.PasswordList = "12345, 54321, abcde";
    }

    public LoginPageViewModel()
    {
    }

    private async void LoginAsync()
    {
        var validar = await loginService.LoginAsync(Usuario, Contraseña);

        if (validar == false)
        {
            await ShowToastAsync("No fue posible iniciar sesion");
            return;
        }
        await ShowToastAsync("Inicio de Sesion Satisfactorio");
        await Shell.Current.GoToAsync($"///{nameof(PreguntasPage)}");
    }

    private async Task ShowToastAsync(string message)
    {
        // implement your logic here
        var toast = Toast.Make(message);
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        await toast.Show(cts.Token);
    }
    public event PropertyChangedEventHandler PropertyChanged;
}