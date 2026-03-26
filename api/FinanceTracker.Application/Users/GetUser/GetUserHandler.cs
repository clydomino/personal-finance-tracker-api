using FinanceTracker.Domain;
using MediatR;

namespace FinanceTracker.Application.Users.GetUser
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, GetUserResult>
    {
        private readonly IUserRepository _userRepository;

        public GetUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<GetUserResult> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id, cancellationToken);

            if (user == null)
            {
                return new GetUserResult(false, "User not found", null, null, null, null);
            }

            return new GetUserResult(true, null, user.Id, user.Email, user?.FirstName, user?.LastName);
        }
    }
}
