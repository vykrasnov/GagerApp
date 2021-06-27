using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GagerApp.Core.Services;

namespace GagerApp.Manager.Services
{
    public class DummyLoginService : ILoginService
    {
        public Task<LoginResult> LoginAsync(string username, string password)
        {
            if (username == "testuser1" && password == "testuser1")
            {
                return Task.FromResult(LoginResult.Success);
            }

            return Task.FromResult(LoginResult.InvalidCredentials);
        }
    }
}
