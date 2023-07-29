using Xamarin.Forms;
using XamarinApp.Views;

namespace XamarinApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        private string _username;
        private string _password;
        private string name;
        private string _WelcomeMessage;
        private Color _MessageColor;
        private bool _ShowMessage;


        public string UserName
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }
        public string PassWord
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        public Color MessageColor
        {
            get => _MessageColor;
            set
            {
                if (_MessageColor != value)
                {
                    _MessageColor = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool ShowMessage
        {
            get => _ShowMessage;
            set
            {
                if (_ShowMessage != value)
                {
                    _ShowMessage = value;
                    OnPropertyChanged();
                }
            }
        }

        public string WelcomeMessage
        {
            get => _WelcomeMessage;
            set
            {
                if (_WelcomeMessage != value)
                {
                    _WelcomeMessage = value;
                    OnPropertyChanged();
                }
            }
        }



        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {

            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            if (ValidateFields())
            {
                if (UserName == "a" && PassWord == "a")
                {
                    name = "a";
                    WelcomeMessage = "Correcto";
                    MessageColor = Color.Green;
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                }
                else
                {
                    ShowMessage = true;
                    MessageColor = Color.Red;
                    WelcomeMessage = "Usuario y contraseña incorrecto";
                }

            }

            //await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(PassWord))
            {
                return false;
            }
            return true;
        }

    }
}
