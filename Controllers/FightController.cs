using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.rpg.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.rpg.Controllers
{
    [ApiController]
    [Route("[Controller")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;

        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }
    }
}