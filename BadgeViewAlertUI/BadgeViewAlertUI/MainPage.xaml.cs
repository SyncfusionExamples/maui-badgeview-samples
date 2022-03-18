using Syncfusion.Maui.Core;

namespace BadgeViewAlertUI;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		this.iconPicker.Items.Add("Available");
		this.iconPicker.Items.Add("Busy");
		this.iconPicker.Items.Add("Away");
		this.iconPicker.Items.Add("Offline");
		this.iconPicker.SelectedIndex = 0;
        this.iconPicker.SelectedIndexChanged += IconPicker_SelectedIndexChanged;

		GetMessageCount();
	}

	int count = 0;
	private async void GetMessageCount()
    {
		while (true)
		{
			await Task.Delay(1000);
			count++;
			this.animationBadgeView.BadgeText = count.ToString();
		}
    }

    private void IconPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
		if (this.iconPicker.SelectedIndex == 0)
		{
			this.badgeSettings.Icon = Syncfusion.Maui.Core.BadgeIcon.Available;
			this.badgeSettings.Background = Colors.Green;
		}
		else if (this.iconPicker.SelectedIndex == 1)
		{
			this.badgeSettings.Icon = Syncfusion.Maui.Core.BadgeIcon.Busy;
			this.badgeSettings.Background = Colors.Red;
		}
		else if (this.iconPicker.SelectedIndex == 2)
		{
			this.badgeSettings.Icon = Syncfusion.Maui.Core.BadgeIcon.Away;
			this.badgeSettings.Background = Colors.Orange;
		}
		else if (this.iconPicker.SelectedIndex == 3)
		{
			this.badgeSettings.Icon = Syncfusion.Maui.Core.BadgeIcon.Delete;
			this.badgeSettings.Background = Colors.Gray;
		}
	}
}

