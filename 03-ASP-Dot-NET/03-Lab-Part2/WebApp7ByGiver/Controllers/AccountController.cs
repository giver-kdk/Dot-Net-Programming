using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebApp7ByGiver.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("RegisterUser")]
        public async Task<IActionResult> Register(RegisterRequest model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                    var result = await _userManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        // Handle successful registration
                        return new OkObjectResult("User Register Successfully ");
                    }
                    else
                    {
                        return new BadRequestObjectResult("There was an error processing your request, please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginRequest model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    // return your customize result 
                    return new OkObjectResult(result);
                }
                else
                {
                    return new OkObjectResult(new LoginResponsenModel { Status = LoginStatus.Failed, Message = result.Message });
                }
            }

        }
    }
}
