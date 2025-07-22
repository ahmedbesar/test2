using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace test2.Pages;

public class IndexModel : test2PageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
