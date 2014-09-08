using System;
using Xamarin.Forms;

namespace SimpleLoginForms
{
	public class App
	{
		private static Page _NavPage;
		public static Page RootPage()
		{
			_NavPage = new NavigationPage(new ProfileView());

			return _NavPage;
		}

		public static bool IsLoggedIn
		{
			get { return !string.IsNullOrWhiteSpace(_Token); }
		}

		static string _Token;
		public static string Token
		{
			get { return _Token; }
		}

		public static void SaveToken(string token)
		{
			_Token = token;
		}

		public static Action SuccessfulLoginAction
		{
			get
			{
				return new Action(() =>
					{
						_NavPage.Navigation.PopModalAsync();
					});
			}
		}
	}
}