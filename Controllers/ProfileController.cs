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
            var Current_day = DateTime.UtcNow/*.AddHours()*/;
            var gitHubFileUrl = $"https://github.com/Ojelcode";

            // Get the GitHub URL of the full source code
            var gitHubSourceUrl = "https://github.com/Ojelcode/YourRepo";

            var profile = new
            {
                SlackName = slackName,
                CurrentDayOfWeek = Current_day.DayOfWeek.ToString(),
                CurrentUTCTime = Current_day,
                Track = track,
                GitHubFileUrl = gitHubFileUrl,
                GitHubSourceUrl = gitHubSourceUrl
            };

            return Json(profile);


        }

    }
}




