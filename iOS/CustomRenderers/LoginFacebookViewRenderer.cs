using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using SimpleLoginForms;
using SimpleLoginForms.iOS;

[assembly: ExportRenderer(typeof(LoginFacebookView), typeof(LoginFacebookViewRenderer))]
namespace SimpleLoginForms.iOS
{
	public class LoginFacebookViewRenderer : PageRenderer
	{
		public LoginFacebookViewRenderer ()
		{
		}
	}
}