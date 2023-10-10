namespace AppThemeBug
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Dark_OnClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
            {
                Application.Current.UserAppTheme = AppTheme.Dark;
            }
        }

        private void Light_OnClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
            {
                Application.Current.UserAppTheme = AppTheme.Light;
            }
        }

        private void Unspecified_OnClicked(object sender, EventArgs e)
        {
            if (Application.Current != null)
            {
                Application.Current.UserAppTheme = AppTheme.Unspecified;
            }
        }
    }
}