using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Application.Users.CreateUser
{
    public record CreateUserResult(
      Guid Id,
      string Email,
      string FirstName,
      string LastName
  );

}
