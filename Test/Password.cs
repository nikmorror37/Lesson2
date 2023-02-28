using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Password
    {
        private string confirmPassword;
        public string Value { get; set; } = " ";
        public string ConfirmPassword
        {
            get => confirmPassword;
            set
            {
                if (!Value.Equals(value))
                    throw new PasswordException("Пароли не совпадают");
                else
                    confirmPassword = value;
            }
        }
    }
}
