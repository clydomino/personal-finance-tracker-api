using FinanceTracker.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FinanceTrackerDbContext _context;

        public UserRepository(FinanceTrackerDbContext context)
        {
            _context = context;
        }

        async Task IUserRepository.AddAsync(User user, CancellationToken cancellationToken)
        {
            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync(cancellationToken);
        }

        async Task<User?> IUserRepository.GetByEmailAsync(string email, CancellationToken cancellationToken)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
        }

        async Task<User?> IUserRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Users.FirstOrDefaultAsync(u => id == u.Id, cancellationToken);
        }
    }
}
