namespace MauiApp1 {
	public partial class MainPage : ContentPage {
		int count = 0;

		public MainPage() {
			InitializeComponent();
		}

		private void OnSizeChanged(object sender, System.EventArgs e) {
			if (ResponsiveGrid.Width > 600)
			{
				ResponsiveGrid.ColumnDefinitions[0].Width = new GridLength(1, GridUnitType.Star);
				ResponsiveGrid.ColumnDefinitions[1].Width = new GridLength(2, GridUnitType.Star);
				ResponsiveGrid.ColumnDefinitions[2].Width = new GridLength(1, GridUnitType.Star);
				ResponsiveGrid.SetRow(mentesgomb, 1);
				ResponsiveGrid.SetColumn(mentesgomb, 2);
				ResponsiveGrid.SetRowSpan(mentesgomb, 2);
				mentesgomb.HorizontalOptions = LayoutOptions.Center;
				mentesgomb.VerticalOptions = LayoutOptions.Center;
				mentesgomb.Margin = 0;
				ResponsiveGrid.SetColumnSpan(mentesgomb, 1);
				ResponsiveGrid.SetColumn(kilepesgomb, 2);
				ResponsiveGrid.SetColumnSpan(kilepesgomb, 1);
				message.VerticalOptions = LayoutOptions.Center;
			}
			else {
				ResponsiveGrid.ColumnDefinitions[0].Width = new GridLength(2, GridUnitType.Star);
				ResponsiveGrid.ColumnDefinitions[1].Width = new GridLength(5, GridUnitType.Star);
				ResponsiveGrid.ColumnDefinitions[2].Width = new GridLength(0, GridUnitType.Star);
				ResponsiveGrid.SetRow(mentesgomb, 6);
				ResponsiveGrid.SetColumn(mentesgomb, 0);
				ResponsiveGrid.SetRowSpan(mentesgomb, 1);
				ResponsiveGrid.SetColumnSpan(mentesgomb, 2);
				mentesgomb.HorizontalOptions = LayoutOptions.Start;
				mentesgomb.VerticalOptions = LayoutOptions.End;
				mentesgomb.Margin = 20;
				ResponsiveGrid.SetColumn(kilepesgomb, 0);
				ResponsiveGrid.SetColumnSpan(kilepesgomb, 2);
				message.VerticalOptions = LayoutOptions.Start;
			}
        }

	}

}
