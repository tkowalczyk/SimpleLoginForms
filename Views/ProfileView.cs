using System;
using Xamarin.Forms;

namespace SimpleLoginForms
{
	public class ProfileView : LoggedView
	{
		#region Ctor
		public ProfileView()
		{
			this.Content = new Label
			{
				Text = "Profile View",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
		#endregion
	}
}