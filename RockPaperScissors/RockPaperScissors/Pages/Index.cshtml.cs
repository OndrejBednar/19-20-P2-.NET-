using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RockPaperScissors.Service;

namespace RockPaperScissors.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RpsLogic _rpsLogic;

        public IndexModel(RpsLogic rpsLogic)
        {
            _rpsLogic = rpsLogic;
        }

        public RpsLogic GameData { get; set; }

        public void OnGet()
        {
            GameData = _rpsLogic.userData;
        }
    }
}
