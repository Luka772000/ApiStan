using APARTMENTS.Dtos;
using APARTMENTS.Interfaces;
using APARTMENTS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Controller
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IUserApartmentService _userApService;
        private readonly Context _context;
        public ContractController(IUserApartmentService userApService, Context context)
        {
            _userApService = userApService;
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateContractDto newContract)
        {
            return Ok();
        }
    }
}
