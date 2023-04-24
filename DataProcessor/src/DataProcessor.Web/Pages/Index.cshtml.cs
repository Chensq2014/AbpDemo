using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace DataProcessor.Web.Pages;

public class IndexModel : DataProcessorPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
