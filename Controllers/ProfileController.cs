using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BackendStageOneTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetProfile([FromQuery] string slackName, [FromQuery] string track)
        {
            var Current_day = DateTime.UtcNow;
            var gitHubFileUrl = $"https://github.com/Ojelcodes/HNGStage1.git";

            
            var gitHubSourceUrl = "https://github.com/Ojelcode/HNGStage1";
            int  StatusCode = 200;

            var profile = new
            {
                SlackName = slackName,
                CurrentDayOfWeek = Current_day.DayOfWeek.ToString(),
                CurrentUTCTime = Current_day,
                Track = track,
                GitHubFileUrl = gitHubFileUrl,
                GitHubSourceUrl = gitHubSourceUrl,
                Staus_code= StatusCode,
            };

             return Json(profile);


        }

    }
}





