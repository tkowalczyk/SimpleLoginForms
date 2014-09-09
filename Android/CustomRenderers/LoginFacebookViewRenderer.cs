using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using SimpleLoginForms;
using SimpleLoginForms.Android;

[assembly: ExportRenderer(typeof(LoginFacebookView), typeof(LoginFacebookViewRenderer))]
namespace SimpleLoginForms.Android
{
	public class LoginFacebookViewRenderer : PageRenderer
	{
		public LoginFacebookViewRenderer ()
		{
		}
	}
}