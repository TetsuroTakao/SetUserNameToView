using Microsoft.AspNetCore.Mvc;

namespace React.Sample.Webpack.CoreMvc.Controllers
{
	public class AccountController : Controller
    {
		[Route("Account/SignIn")]
		[ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
		public void SignIn()
		{
			var tenant = "__YOUR TENANT__";//this grant_type allows common
			var clientId = "__APP CLIENT ID__";
			var redirectUri = "http://localhost:9457/home";
			Response.Redirect("https://login.microsoftonline.com/" + tenant 
				+ "/oauth2/v2.0/authorize?client_id=" + clientId + "&redirect_uri=" 
				+ redirectUri + "&grant_type=implicit&response_type=code&scope=User.Read"
				);
		}
	}
}
