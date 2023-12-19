namespace ExamenParcial2.Models;

public static class Settings
{
    public static bool IsAuthenticated
    {
        get => Preferences.Default.Get(nameof(IsAuthenticated), false);
        set => Preferences.Default.Set(nameof(IsAuthenticated), value);
    }

    public static string EmailList
    {
        get => Preferences.Default.Get(nameof(EmailList), string.Empty);
        set => Preferences.Default.Set(nameof(EmailList), value);
    }

    public static string PasswordList
    {
        get => Preferences.Default.Get(nameof(PasswordList), string.Empty);
        set => Preferences.Default.Set(nameof(PasswordList), value);
    }
    public static int RespuestaPregunta1
    {
        get => Preferences.Get(nameof(RespuestaPregunta1), 0);
        set => Preferences.Set(nameof(RespuestaPregunta1), value);
    }

    public static double RespuestaPregunta2
    {
        get => Preferences.Get(nameof(RespuestaPregunta2), 0.0);
        set => Preferences.Set(nameof(RespuestaPregunta2), value);
    }

    public static int RespuestaPregunta3
    {
        get => Preferences.Get(nameof(RespuestaPregunta3), 0);
        set => Preferences.Set(nameof(RespuestaPregunta3), value);
    }
}