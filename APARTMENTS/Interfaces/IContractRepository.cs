using APARTMENTS.Dtos;
using APARTMENTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Interfaces
{
    public interface IContractRepository
    {
        void AddContract(Contract contract);
        void DeleteContract(Contract contract);
        Task<Contract> GetUserContract(int UserId);
        Task<User> GetUserWithContract(int userId);
        Task<IEnumerable<CreateContractDto>> GetContracts(string predicate, int UserId);
    }
}
