using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webapp07ByGiver.Pages.User
{
    [Authorize(Roles = "Admin, Member")]
    public class MemberModel : PageModel
    {
        public void OnGet()
        {
           
        }
    }
}
