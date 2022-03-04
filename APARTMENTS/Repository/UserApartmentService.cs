using APARTMENTS.Dtos;
using APARTMENTS.Interfaces;
using APARTMENTS.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Repository
{
    public class UserApartmentService : IUserApartmentService
    {
        private readonly Context _context;
        
        private readonly IMapper _mapper;
        public UserApartmentService(Context context, IMapper mapper)    
        {
            _mapper = mapper;
            
            _context = context;
        }

        public async Task AddUserApartment(CreateContractDto newUserApartmentContract)
        {
            User user = await _context.Users
               .Include(u => u.contracts)
               .Include(u => u.contracts).ThenInclude(cs => cs.Apartment)
               .FirstOrDefaultAsync(u => u.Id == newUserApartmentContract.UserId);


            Apartment apartment = await _context.Apartments
                .FirstOrDefaultAsync(u => u.Id == newUserApartmentContract.ApartmentId);


            Contract contract = new Contract
            {
                User = user,
                Apartment = apartment
            };
            await _context.Contracts.AddAsync(contract);
            await _context.SaveChangesAsync();

            

        }
    }
}
