using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Weapon;
using dotnet_rpg.Dtos.Skill;

namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto,Character>();
            CreateMap<Weapon,GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}