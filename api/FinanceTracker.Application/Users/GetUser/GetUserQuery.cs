using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Application.Users.GetUser
{
    public record GetUserQuery(Guid Id)
    : IRequest<GetUserResult>;
}
