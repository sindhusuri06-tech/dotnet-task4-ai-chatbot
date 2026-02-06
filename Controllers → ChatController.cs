using System.Web.Mvc;
using ChatBotApp.Models;

namespace ChatBotApp.Controllers
{
    public class ChatController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reply(ChatMessage msg)
        {
            string response = "";

            string user = msg.UserMessage.ToLower();

            if (user.Contains("hi") || user.Contains("hello"))
                response = "Hello! How can I help you?";

            else if (user.Contains("price"))
                response = "Please check our product section.";

            else if (user.Contains("help"))
                response = "Sure, I'm here to help you.";

            else
                response = "Sorry, I didn't understand that.";

            ViewBag.Bot = response;

            return View("Index");
        }
    }
}
