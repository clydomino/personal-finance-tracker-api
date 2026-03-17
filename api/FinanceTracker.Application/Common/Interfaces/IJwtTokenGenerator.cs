using FinanceTracker.Domain;

namespace FinanceTracker.Application.Common.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
