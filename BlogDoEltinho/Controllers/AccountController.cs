using AutoMapper;
using BlogDoEltinho.Dtos.RegisterUserDto;
using BlogDoEltinho.Interface;
using BlogDoEltinho.Models;
using BlogDoEltinho.Services;
using Microsoft.AspNetCore.Authorization;
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
        private readonly ITokenService _tokenService;

        public AccountController(IMapper mapper ,UserManager<UserInfo> usermanager, ITokenService tokenservice)
        {
            _userManager = usermanager;
            _mapper = mapper;
            _tokenService = tokenservice;
        }

 
        [HttpPost("Register")]
        public async Task<IActionResult> CreateAccount(UserForRegisterDto registerDto)
        {
          try
            {
                 if(!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (registerDto is null)
                {
                    return BadRequest("Não foi póssivel achar o registro");
                }

               var user = new UserInfo { UserName = registerDto.UserName, Email = registerDto.Email };

               var createUser = await _userManager!.CreateAsync(user, registerDto.Password);

               if(createUser.Succeeded)
                {
                    var tokenCreate = _tokenService.CreateToken(user);
                    return Ok(tokenCreate);
                }

               else
                {
                    return StatusCode(500, createUser.Errors);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

           
        }
        
    }
}
