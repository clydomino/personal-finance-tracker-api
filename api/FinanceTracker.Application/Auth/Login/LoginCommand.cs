using FinanceTracker.Application.Users.CreateUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Application.Auth.Login
{

    public record LoginCommand(
       string Email,
       string Password
       ) : IRequest<LoginResult>;

}
