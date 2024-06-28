namespace BadgeViewAutoHide
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            count++;

            if (count <= 3)
                badgeView.BadgeText = $"{count}";
            else
            {
                count = 0;
                badgeView.BadgeText = $"{count}";
            }
        }
    }

}
