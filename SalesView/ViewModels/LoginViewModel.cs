using SalesSystem.Librery;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Services.TargetedContent;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SalesSystem.ViewModels
{
    public class LoginViewModel : UserModel
    {
        private ICommand _command;
        private TextBox _textBoxEmail;
        private PasswordBox _passwordBoxEmail;
        private string date = DateTime.Now.ToString("dd/MMM/yyy");
        private Frame rootFrame = Window.Current.Content as Frame;

        public LoginViewModel(Object[] campos)
        {
            _textBoxEmail = (TextBox)campos[0];
            _passwordBoxEmail = (PasswordBox)campos[1];
        }
        public ICommand IniciarCommand
        {
            get 
            {
                return _command ?? (_command = new CommandHandler(async () =>
                {
                    await IniciarAsync();
                }));
            }
        }
        private async Task IniciarAsync()
        {
            var data = Email;
        }
    }
}
