namespace Practice.views;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	public void OnHorizontalStartClicked(object sender, EventArgs e)
	{
		target.HorizontalOptions = LayoutOptions.Start;
	}
    public void OnHorizontalCenterClicked(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.Center;
    }
    public void OnHorizontalEndClicked(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.End;
    }
    public void OnHorizontalFillClicked(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.Fill;
    }

    public void OnVerticalStartClicked(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.Start;
    }
    public void OnVerticalCenterClicked(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.Center;
    }
    public void OnVerticalEndClicked(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.End;
    }
    public void OnVerticalFillClicked(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.Fill;
    }
}

