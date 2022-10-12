using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.rpg.Dtos.Skill;
using dotnet.rpg.Dtos.Weapon;

namespace dotnet.rpg.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Spider-Man";
        public int HitPoints { get; set; } = 101;
        public int Strength { get; set; } = 9;
        public int Defense { get; set; } = 11;
        public int Intelligence { get; set; } = 69;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public GetWeaponDto Weapon { get; set; }
        public List<GetSkillDto> Skills { get; set; }

        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }

    }
}