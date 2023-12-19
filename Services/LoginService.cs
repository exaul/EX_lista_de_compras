using ExamenParcial2.ViewModels;
using ExamenParcial2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenParcial2.Models;

namespace ExamenParcial2.Services;

public class LoginService : ILoginService
{
    public async Task<bool> LoginAsync(string usuario, string contraseña)
    {
        var result = false;
        if (string.IsNullOrEmpty(usuario))
        {
            return result;
        }
        if (string.IsNullOrEmpty(contraseña))
        {
            return result;
        }

        await Task.Delay(250);

        string[] emailArray = Settings.EmailList.Split(',');
        var emailList = new List<KeyValuePair<int, string>>();

        for (int i = 0; i < emailArray.Length; i++)
        {
            emailList.Add(new(i, emailArray[i]));
        }

        string[] passwordArray = Settings.PasswordList.Split(',');
        var passwordList = new List<KeyValuePair<int, string>>();

        for (int i = 0; i < passwordArray.Length; i++)
        {
            passwordList.Add(new(i, passwordArray[i]));
        }

        var loginDataEmail = emailList.FirstOrDefault(x => x.Value == usuario);
        if (loginDataEmail.Equals(default(KeyValuePair<string, string>)))
        {
            return result;
        }

        if (loginDataEmail.Value != usuario)
        {
            return result;
        }

        var loginDataPassword = passwordList.FirstOrDefault(x => x.Key == loginDataEmail.Key);
        if (loginDataPassword.Equals(default(KeyValuePair<string, string>)))
        {
            return result;
        }

        if (loginDataPassword.Value != contraseña)
        {
            return result;
        }
        return true;
    }
}