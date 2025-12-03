using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.UserDtos;
using OnlineEdu.WebUI.Services.UserServices;

namespace OnlineEdu.WebUI.Controllers
{
    public class RegisterController(IUserService userService) : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> SignUp(UserRegisterDto userRegisterDto)
        {
            var result = await userService.CreateUserAsync(userRegisterDto);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.Code, item.Description);
                }
                return View();
            }
            return RedirectToAction("Index","Login");
        }
    }
}
