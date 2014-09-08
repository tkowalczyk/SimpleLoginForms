using System;

namespace SimpleLoginForms
{
	public abstract class LoggedView : BaseView
	{
		#region Ctor
		public LoggedView()
		{

		}
		#endregion

		#region Overrides
		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (!App.IsLoggedIn)
			{
				Navigation.PushModalAsync(new MainView());
			}
		}
		#endregion
	}
}