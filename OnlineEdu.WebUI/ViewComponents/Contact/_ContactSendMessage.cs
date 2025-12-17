using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.MessageDtos;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.ViewComponents.Contact
{
    public class _ContactSendMessage:ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public IViewComponentResult Invoke()
        {
            return View();
        }

        
    }
}
