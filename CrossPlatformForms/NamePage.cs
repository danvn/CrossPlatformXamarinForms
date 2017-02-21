using System;

using Xamarin.Forms;

namespace CrossPlatformForms
{
	public class NamePage : ContentPage
	{
		public NamePage()
		{
			Label labelFirst = new Label
			{
				Text = "First Name",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			Entry firstName = new Entry
			{
				Placeholder = "enter name",
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Keyboard = Keyboard.Text
			};

			Button submitName = new Button
			{
				Text = "Submit",
				FontSize = 25,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					labelFirst,
					firstName,
					submitName
				},
				HeightRequest = 1500
			};

			this.Content = stackLayout;


		}
	}
}

