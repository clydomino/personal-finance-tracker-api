using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Application.Auth.Login
{

    public record LoginResult(
        bool Success,
        string? Error,
        string? Token
    );

}
