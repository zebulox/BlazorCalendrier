using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Services.Interface
{
    public interface IAuthentifier
    {
        bool LogIn(String login, String password);
    }
}
