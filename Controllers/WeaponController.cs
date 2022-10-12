using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.rpg.Dtos.Character;
using dotnet.rpg.Dtos.Weapon;
using dotnet.rpg.Services.WeaponService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.rpg.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpPost("Addweapon")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> Addweapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }

    }
}