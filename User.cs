// Task3/User.cs
using System;

namespace Task3
{
    public class User
    {
        private string login;
        private string password;

        public string Login
        {
            get => login;
            set
            {
                string error = string.IsNullOrEmpty(value) ? "Логин не может быть пустым." : string.Empty;
                if (login != value)
                {
                    login = value;
                    OnDataChanged?.Invoke(this, new InfoEventArgs
                    {
                        PropertyName = nameof(Login),
                        ErrorText = error,
                        ChangeDate = DateTime.Now
                    });
                }
            }
        }

        public string Password
        {
            get => password;
            set
            {
                string error = value != null && (value.Length < 6 || value.Length > 20) ? "Пароль должен содержать от 6 до 20 символов." : string.Empty;
                if (password != value)
                {
                    password = value;
                    OnDataChanged?.Invoke(this, new InfoEventArgs 
                    {
                        PropertyName = nameof(Password),
                        ErrorText = error,
                        ChangeDate = DateTime.Now
                    });
                }
            }
        }

        public event EventHandler<InfoEventArgs> OnDataChanged; 
    }
}