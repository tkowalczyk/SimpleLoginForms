using System;
using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;

namespace SimpleLoginForms
{
	public class MainView : BaseView
	{
		#region ToolBarItems
		private void OpenSignUpView()
		{
			Navigation.PushAsync(new SignUpView());
		}

		private void OpenSignInView()
		{
			Navigation.PushAsync(new SignInView());
		}

		private void OpenSignOutView()
		{
			App.SaveToken("");
			DisplayAlert("SignOut", "SignOut Success", "OK");
			Navigation.PushAsync(new MainView());
		}

		private void OpenSettingsView()
		{
			Navigation.PushAsync(new SettingsView());
		}

		private IList<ToolbarItem> GetToolBarItems()
		{
			var list = new List<ToolbarItem>();

			var tiGrid = new ToolbarItem
			{
				Priority = 0,
				Order = ToolbarItemOrder.Primary
			};

			list.Add(tiGrid);

			if (!App.IsLoggedIn)
			{
				list.Add(
					new ToolbarItem(
						"Sign In",
						"signin.png",
						OpenSignInView,
						ToolbarItemOrder.Secondary, 2)
				);
				list.Add(
					new ToolbarItem(
						"Sign Up",
						"signup.png",
						OpenSignUpView,
						ToolbarItemOrder.Secondary, 3)
				);
			}
			else
			{
				list.Add(
					new ToolbarItem(
						"Settings",
						"settings.png",
						OpenSettingsView,
						ToolbarItemOrder.Secondary, 2)
				);
				list.Add(
					new ToolbarItem(
						"Sign Out",
						"signout.png",
						OpenSignOutView,
						ToolbarItemOrder.Secondary, 3)
				);
			}

			return list;
		}
		#endregion

		#region Ctor
		public MainView()
		{
			this.Content = new Label
			{
				Text = "Main View",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
		#endregion

		#region Overrides
		protected override void OnAppearing()
		{
			base.OnAppearing();

			this.ToolbarItems.Clear();

			var toolBarItemsList = new List<ToolbarItem>();
			toolBarItemsList = GetToolBarItems().ToList<ToolbarItem>();

			foreach (var toolBarItem in toolBarItemsList)
			{
				this.ToolbarItems.Add(toolBarItem);
			}
		}
		#endregion
	}
}