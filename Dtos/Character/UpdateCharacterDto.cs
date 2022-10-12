using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.rpg.Dtos.Character
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Spider-Man";
        public int HitPoints { get; set; } = 101;
        public int Strength { get; set; } = 9;
        public int Defense { get; set; } = 11;
        public int Intelligence { get; set; } = 69;
        public RpgClass Class { get; set; } = RpgClass.Knight;

    }
}