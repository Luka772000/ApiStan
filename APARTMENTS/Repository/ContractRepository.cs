using APARTMENTS.Dtos;
using APARTMENTS.Interfaces;
using APARTMENTS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Repository
{
    public class ContractRepository : IContractRepository
    {
        private readonly Context context;

        public ContractRepository(Context context)
        {
            this.context = context;
        }

        public async Task<Contract> GetUserContract(int UserId)
        {
            return await context.Contracts.FindAsync(UserId);
        }

        

        public async Task<User> GetUserWithContract(int userId)
        {
            return await context.Users
                .Include(x => x.contracts)
                .FirstOrDefaultAsync(x => x.Id == userId);
        }

        public void AddContract(Contract contract)
        {
            throw new NotImplementedException();
        }

        public void DeleteContract(Contract contract)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CreateContractDto>> GetContracts(string predicate, int UserId)
        {
            throw new NotImplementedException();
        }
    }
}
