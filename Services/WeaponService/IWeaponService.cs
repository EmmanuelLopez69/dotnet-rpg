using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.rpg.Dtos.Character;
using dotnet.rpg.Dtos.Weapon;

namespace dotnet.rpg.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto >> AddWeapon(AddWeaponDto newWeapon);
    }
}