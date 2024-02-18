using ChatGptNet;
using ChatGptNet.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace HuquqshunosAiApi.Controllers
{
    [Route("/chat")]
    public class ChatController : Controller
    {
        private readonly IChatGptClient chatGptClient;

        public ChatController(IChatGptClient chatGptClient)
        {
            this.chatGptClient = chatGptClient;
        }

        [Route("/chat/SomeRequest")]
        [HttpGet]
        public async Task<string?> SomeRequest()
        {
            var res = await chatGptClient.AskAsync("Tell me about yourself");

            return res.GetContent();
        }
    }
}
