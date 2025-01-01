using AutoMapper;
using BlogDoEltinho.Dtos.RegisterUserDto;
using BlogDoEltinho.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogDoEltinho.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<UserInfo>? _userManager;
        private readonly IMapper _mapper;

        public AccountController(IMapper mapper ,UserManager<UserInfo> usermanager)
        {
            _userManager = usermanager;
            _mapper = mapper;
        }


        
    }
}
