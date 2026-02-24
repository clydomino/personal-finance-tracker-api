using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

using MediatR;

namespace FinanceTracker.Application.Users.CreateUser
{
    public record CreateUserCommand (
        string Email,
        string FirstName,
        string LastName,
        string Password
        ) : IRequest<CreateUserResult>;
}
