using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Application.Users.GetUser
{
    public record GetUserResult(
        bool Success,
        string? Error,
        Guid? Id,
        string? Email,
        string? FirstName,
        string? LastName
 );
}
