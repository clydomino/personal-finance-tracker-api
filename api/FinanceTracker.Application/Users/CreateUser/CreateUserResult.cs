namespace FinanceTracker.Application.Users.CreateUser
{
    public record CreateUserResult(
        bool success,
        string? error,
        Guid? Id,
        string Email,
        string FirstName,
        string LastName
  );

}
