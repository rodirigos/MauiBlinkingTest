namespace MauiBlinkingTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            int count = 10;
            for (int i = 0; i < count; i++)
            {
                var grid = new Grid();
                grid.Children.Add(new Label
                {
                    Text = i.ToString(),
                    TextColor = Colors.White,
                    BackgroundColor = Colors.Black
                });

                var Page = new ContentPage()
                {
                    Content = grid,
                };


                Application.Current?.OpenWindow(new Window()
                {
                    Page = Page
                });
            }
        }
    }

}
