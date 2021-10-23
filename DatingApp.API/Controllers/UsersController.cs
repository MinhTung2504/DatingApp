using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DatingApp.DatingApp.API.Database;
using DatingApp.API.Database.Entities;
using Microsoft.AspNetCore.Authorization;
using DatingApp.API.Database.Repositories;
using DatingApp.API.DTOs;
using AutoMapper;

namespace DatingApp.API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {

        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(_userRepository.GetMembers());
        }

        [HttpGet("{username}")]
        public ActionResult<MemberDto> Get(string username)
        {
            var member = _userRepository.GetMemberByUsername(username);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }
    }
}
